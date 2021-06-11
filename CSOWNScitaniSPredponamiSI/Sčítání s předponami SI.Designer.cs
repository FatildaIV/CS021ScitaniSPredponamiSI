
namespace CSOWNScitaniSPredponamiSI
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.rovnaSe = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(216, 44);
            this.textBox.TabIndex = 0;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(267, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 37);
            this.label.TabIndex = 1;
            this.label.Text = "0";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(199, 62);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(103, 21);
            this.button.TabIndex = 2;
            this.button.Text = "Reset";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // rovnaSe
            // 
            this.rovnaSe.AutoSize = true;
            this.rovnaSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.rovnaSe.Location = new System.Drawing.Point(234, 15);
            this.rovnaSe.Name = "rovnaSe";
            this.rovnaSe.Size = new System.Drawing.Size(36, 38);
            this.rovnaSe.TabIndex = 3;
            this.rovnaSe.Text = "=";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(408, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "3.D Hofman Karel";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1k",
            "1.k"});
            this.comboBox.Location = new System.Drawing.Point(12, 62);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(110, 21);
            this.comboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 89);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.rovnaSe);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sčítání s předponami SI";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label rovnaSe;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

