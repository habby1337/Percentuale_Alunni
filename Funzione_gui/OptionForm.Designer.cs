namespace Funzione_gui
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.lver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bupdate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lver
            // 
            this.lver.AutoSize = true;
            this.lver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lver.Location = new System.Drawing.Point(39, 123);
            this.lver.Name = "lver";
            this.lver.Size = new System.Drawing.Size(91, 16);
            this.lver.TabIndex = 2;
            this.lver.Text = "Versione: 0.0.0.0";
            this.lver.Click += new System.EventHandler(this.lver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 64);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percentuale\r\nAlunni\r";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bupdate
            // 
            this.bupdate.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bupdate.Location = new System.Drawing.Point(42, 142);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(218, 35);
            this.bupdate.TabIndex = 10;
            this.bupdate.Text = "Cerca Aggiornamenti";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 214);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 165);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(390, 412);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lver);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Percentuale Alunni :: Opzioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}