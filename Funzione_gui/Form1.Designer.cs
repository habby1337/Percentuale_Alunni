using System.Drawing;

namespace Funzione_gui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.tbF = new System.Windows.Forms.NumericUpDown();
            this.tbM = new System.Windows.Forms.NumericUpDown();
            this.binsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bexp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.boption = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bimport = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(23, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(23, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Femmine:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(23, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Maschi:";
            // 
            // tbClassName
            // 
            this.tbClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClassName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClassName.ForeColor = System.Drawing.Color.White;
            this.tbClassName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbClassName.Location = new System.Drawing.Point(156, 147);
            this.tbClassName.MaxLength = 4;
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(130, 21);
            this.tbClassName.TabIndex = 1;
            this.tbClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbF
            // 
            this.tbF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbF.ForeColor = System.Drawing.Color.White;
            this.tbF.Location = new System.Drawing.Point(156, 194);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(130, 21);
            this.tbF.TabIndex = 2;
            this.tbF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbM
            // 
            this.tbM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbM.ForeColor = System.Drawing.Color.White;
            this.tbM.Location = new System.Drawing.Point(156, 243);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(130, 21);
            this.tbM.TabIndex = 3;
            this.tbM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // binsert
            // 
            this.binsert.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.binsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binsert.Location = new System.Drawing.Point(28, 337);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(258, 35);
            this.binsert.TabIndex = 4;
            this.binsert.Text = "Inserisci";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HClasse,
            this.HM,
            this.HF,
            this.HTot});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(422, 345);
            this.dataGridView1.TabIndex = 6;
            // 
            // HClasse
            // 
            this.HClasse.HeaderText = "Classe";
            this.HClasse.Name = "HClasse";
            this.HClasse.ReadOnly = true;
            // 
            // HM
            // 
            this.HM.HeaderText = "Maschi";
            this.HM.Name = "HM";
            this.HM.ReadOnly = true;
            // 
            // HF
            // 
            this.HF.HeaderText = "Femmine";
            this.HF.Name = "HF";
            this.HF.ReadOnly = true;
            // 
            // HTot
            // 
            this.HTot.HeaderText = "Totale";
            this.HTot.Name = "HTot";
            this.HTot.ReadOnly = true;
            // 
            // bexp
            // 
            this.bexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bexp.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bexp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bexp.Location = new System.Drawing.Point(10, 429);
            this.bexp.Name = "bexp";
            this.bexp.Size = new System.Drawing.Size(409, 35);
            this.bexp.TabIndex = 7;
            this.bexp.Text = "Esporta";
            this.bexp.UseVisualStyleBackColor = false;
            this.bexp.Click += new System.EventHandler(this.bexp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.boption);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.binsert);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbF);
            this.panel2.Controls.Add(this.tbClassName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 509);
            this.panel2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(158, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // boption
            // 
            this.boption.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.boption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boption.Location = new System.Drawing.Point(37, 429);
            this.boption.Name = "boption";
            this.boption.Size = new System.Drawing.Size(115, 35);
            this.boption.TabIndex = 6;
            this.boption.Text = "Impostazioni";
            this.boption.UseVisualStyleBackColor = true;
            this.boption.Click += new System.EventHandler(this.boption_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 64);
            this.label4.TabIndex = 5;
            this.label4.Text = "Percentuale\r\nAlunni";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 509);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.bimport);
            this.panel1.Controls.Add(this.bclear);
            this.panel1.Controls.Add(this.bdelete);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pBar1);
            this.panel1.Controls.Add(this.bexp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(347, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 509);
            this.panel1.TabIndex = 9;
            // 
            // bimport
            // 
            this.bimport.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bimport.Location = new System.Drawing.Point(453, 130);
            this.bimport.Name = "bimport";
            this.bimport.Size = new System.Drawing.Size(174, 35);
            this.bimport.TabIndex = 17;
            this.bimport.Text = "Importa [XLSX]";
            this.bimport.UseVisualStyleBackColor = true;
            this.bimport.Click += new System.EventHandler(this.bimport_Click);
            // 
            // bclear
            // 
            this.bclear.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bclear.Location = new System.Drawing.Point(453, 20);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(174, 35);
            this.bclear.TabIndex = 16;
            this.bclear.Text = "Pulisci tutto";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bdelete
            // 
            this.bdelete.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdelete.Location = new System.Drawing.Point(453, 73);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(174, 35);
            this.bdelete.TabIndex = 9;
            this.bdelete.Text = "Rimuovi Riga";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "EXCEL",
            "TXT"});
            this.cbType.Location = new System.Drawing.Point(199, 378);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(130, 24);
            this.cbType.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label5.Location = new System.Drawing.Point(66, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Formato esportazione:";
            // 
            // pBar1
            // 
            this.pBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pBar1.ForeColor = System.Drawing.Color.Goldenrod;
            this.pBar1.Location = new System.Drawing.Point(10, 470);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(409, 35);
            this.pBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(989, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Percentuale Alunni :: Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.NumericUpDown tbF;
        private System.Windows.Forms.NumericUpDown tbM;
        private System.Windows.Forms.Button binsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn HM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HF;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTot;
        private System.Windows.Forms.Button bexp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boption;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bimport;
        private System.Windows.Forms.Button bclear;
        public System.Windows.Forms.ProgressBar pBar1;
    }
}

