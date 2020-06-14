namespace SnagaSuncaForma
{
    partial class SnagaSuncaForm
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.buttonIzmeniClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(98, 38);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(140, 22);
            this.textBoxIme.TabIndex = 0;
            // 
            // buttonIzmeniClick
            // 
            this.buttonIzmeniClick.Location = new System.Drawing.Point(471, 477);
            this.buttonIzmeniClick.Name = "buttonIzmeniClick";
            this.buttonIzmeniClick.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeniClick.TabIndex = 1;
            this.buttonIzmeniClick.Text = "Izmeni";
            this.buttonIzmeniClick.UseVisualStyleBackColor = true;
            this.buttonIzmeniClick.Click += new System.EventHandler(this.buttonIzmeniClick_Click);
            // 
            // SnagaSuncaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonIzmeniClick);
            this.Controls.Add(this.textBoxIme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnagaSuncaForm";
            this.Text = "Snaga sunca ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button buttonIzmeniClick;
    }
}

