namespace Slump_Tal_Grafiskt_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonRätta = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.LabelAntalGissningar = new System.Windows.Forms.Label();
            this.TextBoxInmatning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonRätta
            // 
            this.ButtonRätta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRätta.Location = new System.Drawing.Point(347, 224);
            this.ButtonRätta.Name = "ButtonRätta";
            this.ButtonRätta.Size = new System.Drawing.Size(116, 70);
            this.ButtonRätta.TabIndex = 0;
            this.ButtonRätta.Text = "Rätta";
            this.ButtonRätta.UseVisualStyleBackColor = true;
            this.ButtonRätta.Click += new System.EventHandler(this.ButtonRätta_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(93, 88);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(335, 26);
            this.Label.TabIndex = 1;
            this.Label.Text = "Gissa på ett tal mellan 1 och 100.";
            // 
            // LabelAntalGissningar
            // 
            this.LabelAntalGissningar.AutoSize = true;
            this.LabelAntalGissningar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAntalGissningar.Location = new System.Drawing.Point(297, 151);
            this.LabelAntalGissningar.Name = "LabelAntalGissningar";
            this.LabelAntalGissningar.Size = new System.Drawing.Size(191, 26);
            this.LabelAntalGissningar.TabIndex = 2;
            this.LabelAntalGissningar.Text = "Antal gissningar: 0";
            // 
            // TextBoxInmatning
            // 
            this.TextBoxInmatning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInmatning.Location = new System.Drawing.Point(98, 244);
            this.TextBoxInmatning.Name = "TextBoxInmatning";
            this.TextBoxInmatning.Size = new System.Drawing.Size(181, 32);
            this.TextBoxInmatning.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 340);
            this.Controls.Add(this.TextBoxInmatning);
            this.Controls.Add(this.LabelAntalGissningar);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.ButtonRätta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRätta;
        private System.Windows.Forms.Label LabelAntalGissningar;
        public System.Windows.Forms.TextBox TextBoxInmatning;
        public System.Windows.Forms.Label Label;
    }
}

