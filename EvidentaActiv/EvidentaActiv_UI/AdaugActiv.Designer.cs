namespace EvidentaActiv_UI
{
    partial class AdaugActiv
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
            this.lblAn = new System.Windows.Forms.Label();
            this.lblLuna = new System.Windows.Forms.Label();
            this.lblZi = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblTipActiv = new System.Windows.Forms.Label();
            this.cmbZi = new System.Windows.Forms.ComboBox();
            this.cmbLuna = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtOra = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.cmbTipActiv = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(41, 36);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(33, 20);
            this.lblAn.TabIndex = 0;
            this.lblAn.Text = "An:";
            this.lblAn.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLuna
            // 
            this.lblLuna.AutoSize = true;
            this.lblLuna.Location = new System.Drawing.Point(41, 89);
            this.lblLuna.Name = "lblLuna";
            this.lblLuna.Size = new System.Drawing.Size(49, 20);
            this.lblLuna.TabIndex = 1;
            this.lblLuna.Text = "Luna:";
            // 
            // lblZi
            // 
            this.lblZi.AutoSize = true;
            this.lblZi.Location = new System.Drawing.Point(41, 143);
            this.lblZi.Name = "lblZi";
            this.lblZi.Size = new System.Drawing.Size(26, 20);
            this.lblZi.TabIndex = 2;
            this.lblZi.Text = "Zi:";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(41, 200);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(39, 20);
            this.lblOra.TabIndex = 3;
            this.lblOra.Text = "Ora:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(41, 255);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 20);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min:";
            this.lblMin.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTipActiv
            // 
            this.lblTipActiv.AutoSize = true;
            this.lblTipActiv.Location = new System.Drawing.Point(41, 312);
            this.lblTipActiv.Name = "lblTipActiv";
            this.lblTipActiv.Size = new System.Drawing.Size(101, 20);
            this.lblTipActiv.TabIndex = 5;
            this.lblTipActiv.Text = "Tip activitate:";
            // 
            // cmbZi
            // 
            this.cmbZi.FormattingEnabled = true;
            this.cmbZi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbZi.Location = new System.Drawing.Point(180, 135);
            this.cmbZi.Name = "cmbZi";
            this.cmbZi.Size = new System.Drawing.Size(198, 28);
            this.cmbZi.TabIndex = 9;
            // 
            // cmbLuna
            // 
            this.cmbLuna.FormattingEnabled = true;
            this.cmbLuna.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbLuna.Location = new System.Drawing.Point(180, 81);
            this.cmbLuna.Name = "cmbLuna";
            this.cmbLuna.Size = new System.Drawing.Size(198, 28);
            this.cmbLuna.TabIndex = 10;
            this.cmbLuna.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(102, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(289, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 102);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(130, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "CULTURALA";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(170, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "RECREATIONALA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PROFESIONALA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SPORTIVA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(180, 36);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(198, 26);
            this.txtAn.TabIndex = 15;
            this.txtAn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOra
            // 
            this.txtOra.Location = new System.Drawing.Point(180, 194);
            this.txtOra.Name = "txtOra";
            this.txtOra.Size = new System.Drawing.Size(198, 26);
            this.txtOra.TabIndex = 16;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(180, 249);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(198, 26);
            this.txtMin.TabIndex = 17;
            // 
            // cmbTipActiv
            // 
            this.cmbTipActiv.FormattingEnabled = true;
            this.cmbTipActiv.Items.AddRange(new object[] {
            "SPORTIVA",
            "PROFESIONALA",
            "RECREATIONALA",
            "CULTURALA"});
            this.cmbTipActiv.Location = new System.Drawing.Point(180, 304);
            this.cmbTipActiv.Name = "cmbTipActiv";
            this.cmbTipActiv.Size = new System.Drawing.Size(198, 28);
            this.cmbTipActiv.TabIndex = 18;
            // 
            // AdaugActiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(514, 621);
            this.Controls.Add(this.cmbTipActiv);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtOra);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbLuna);
            this.Controls.Add(this.cmbZi);
            this.Controls.Add(this.lblTipActiv);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.lblZi);
            this.Controls.Add(this.lblLuna);
            this.Controls.Add(this.lblAn);
            this.Name = "AdaugActiv";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblLuna;
        private System.Windows.Forms.Label lblZi;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblTipActiv;
        private System.Windows.Forms.ComboBox cmbZi;
        private System.Windows.Forms.ComboBox cmbLuna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtOra;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.ComboBox cmbTipActiv;
    }
}