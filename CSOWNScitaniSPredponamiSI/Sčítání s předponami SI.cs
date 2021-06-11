using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOWNScitaniSPredponamiSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int hodnota1(string vstup, int pocetCifer)
        {
            return (int.Parse(vstup.Remove(pocetCifer, 1)));
        }
        private int hodnota2(string vstup, int pocetCifer, int exponent)
        {
            if (exponent == 0) return (int.Parse(vstup));
            return (int.Parse(vstup.Remove(pocetCifer, 2)));
        }
        private int exponent()
        {
            switch (predpona())
            {
                case "f": return -15;
                case "p": return -12;
                case "n": return -9;
                case "μ": return -6;
                case "m": return -3;
                case "k": return 3;
                case "M": return 6;
                case "G": return 9;
                case "T": return 12;
                case "P": return 15;
                default: return 1;
            }
        }
        private string predpona()
        {
            int rezim = mod(comboBox.Text);
            if(rezim == 1)
            {
                int pocetCifer = textBox.Text.Length - 1;
                return textBox.Text.Substring(pocetCifer, 1);
            }
            else if(rezim == 2)
            {
                string[] vstup = textBox.Text.Split('.');
                try
                {
                    foreach (var word in vstup)
                    {
                        string predpona = vstup[1];
                    }
                    return vstup[1];
                }
                catch
                {
                    return vstup[0];
                }
            }
            else
            {
                return "";
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                int rezim = mod(comboBox.Text);
                double cislo = 0;
                if(rezim == 1)
                {
                    try
                    {
                        int pocetCifer = textBox.Text.Length - 1;
                        cislo = (hodnota1(textBox.Text, pocetCifer) * Math.Pow(10, exponent()));
                        if (int.TryParse(label.Text, out int result) == false) label.Text = cislo.ToString();
                        else label.Text = (double.Parse(label.Text) + cislo).ToString();
                        textBox.Text = "";
                    }
                    catch 
                    {
                        try
                        {
                            cislo = int.Parse(textBox.Text);
                            if (int.TryParse(label.Text, out int result) == false) label.Text = cislo.ToString();
                            else label.Text = (double.Parse(label.Text) + cislo).ToString();
                            textBox.Text = "";
                        }
                        catch { }
                    }
                }
                else if(rezim == 2)
                {
                    try
                    {
                        int pocetCifer = textBox.Text.Length - 2;
                        cislo = (hodnota2(textBox.Text, pocetCifer, exponent()) * Math.Pow(10, exponent()));
                        if (int.TryParse(label.Text, out int result) == false) label.Text = cislo.ToString();
                        else label.Text = (double.Parse(label.Text) + cislo).ToString();
                        textBox.Text = "";
                    }
                    catch
                    {
                        try
                        {
                            cislo = int.Parse(textBox.Text);
                            if (int.TryParse(label.Text, out int result) == false) label.Text = cislo.ToString();
                            else label.Text = (double.Parse(label.Text) + cislo).ToString();
                            textBox.Text = "";
                        }
                        catch { }
                    }
                }
                else System.Windows.Forms.MessageBox.Show("Před výpočtem vyberte režim zadávání.");
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            label.Text = "0";
            textBox.Text = "";
        }
        private int mod(string vstup)
        {
            if(vstup == "1k") return 1;
            if(vstup == "1.k") return 2;
            /* else if (comboBox.Text == "1k+1k")
            {
                return 3;
            }
            else if (comboBox.Text == "1.k+1.k")
            {
                return 4;
            } */
            return 0;
        }
    }
}
