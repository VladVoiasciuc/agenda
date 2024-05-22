namespace EvidentaActiv_UI
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
            this.DataCurenta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxGrActiv = new System.Windows.Forms.ListBox();
            this.dataGridActiv = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.lbGrActiv = new System.Windows.Forms.Label();
            this.lbActiv = new System.Windows.Forms.Label();
            this.AdaugGrActiv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiv)).BeginInit();
            this.SuspendLayout();
            // 
            // DataCurenta
            // 
            this.DataCurenta.AutoSize = true;
            this.DataCurenta.Location = new System.Drawing.Point(40, 23);
            this.DataCurenta.Name = "DataCurenta";
            this.DataCurenta.Size = new System.Drawing.Size(51, 20);
            this.DataCurenta.TabIndex = 0;
            this.DataCurenta.Text = "label1";
            this.DataCurenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(524, 870);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADAUGARE ACTIVITATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(1039, 870);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "STERGERE ACTIVITATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(12, 870);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "AFISARE ACTIVITATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxGrActiv
            // 
            this.listBoxGrActiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listBoxGrActiv.FormattingEnabled = true;
            this.listBoxGrActiv.ItemHeight = 20;
            this.listBoxGrActiv.Location = new System.Drawing.Point(95, 110);
            this.listBoxGrActiv.Name = "listBoxGrActiv";
            this.listBoxGrActiv.Size = new System.Drawing.Size(1082, 124);
            this.listBoxGrActiv.TabIndex = 4;
            this.listBoxGrActiv.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridActiv
            // 
            this.dataGridActiv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridActiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActiv.Location = new System.Drawing.Point(95, 422);
            this.dataGridActiv.Name = "dataGridActiv";
            this.dataGridActiv.ReadOnly = true;
            this.dataGridActiv.RowHeadersWidth = 62;
            this.dataGridActiv.RowTemplate.Height = 28;
            this.dataGridActiv.Size = new System.Drawing.Size(1081, 416);
            this.dataGridActiv.TabIndex = 5;
            this.dataGridActiv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(797, 870);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 41);
            this.button4.TabIndex = 6;
            this.button4.Text = "MODIFICARE ACTIVITATE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lbGrActiv
            // 
            this.lbGrActiv.AutoSize = true;
            this.lbGrActiv.Location = new System.Drawing.Point(40, 72);
            this.lbGrActiv.Name = "lbGrActiv";
            this.lbGrActiv.Size = new System.Drawing.Size(173, 20);
            this.lbGrActiv.TabIndex = 7;
            this.lbGrActiv.Text = "ACTIVITATI DE GRUP";
            // 
            // lbActiv
            // 
            this.lbActiv.AutoSize = true;
            this.lbActiv.Location = new System.Drawing.Point(40, 361);
            this.lbActiv.Name = "lbActiv";
            this.lbActiv.Size = new System.Drawing.Size(95, 20);
            this.lbActiv.TabIndex = 8;
            this.lbActiv.Text = "ACTIVITATI";
            // 
            // AdaugGrActiv
            // 
            this.AdaugGrActiv.BackColor = System.Drawing.Color.Silver;
            this.AdaugGrActiv.Location = new System.Drawing.Point(95, 271);
            this.AdaugGrActiv.Name = "AdaugGrActiv";
            this.AdaugGrActiv.Size = new System.Drawing.Size(348, 41);
            this.AdaugGrActiv.TabIndex = 9;
            this.AdaugGrActiv.Text = "ADAUGARE ACTIVITATE DE GRUP";
            this.AdaugGrActiv.UseVisualStyleBackColor = false;
            this.AdaugGrActiv.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(254, 870);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "CAUTARE ACTIVITATE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1300, 1010);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.AdaugGrActiv);
            this.Controls.Add(this.lbActiv);
            this.Controls.Add(this.lbGrActiv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridActiv);
            this.Controls.Add(this.listBoxGrActiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataCurenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataCurenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxGrActiv;
        private System.Windows.Forms.DataGridView dataGridActiv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbGrActiv;
        private System.Windows.Forms.Label lbActiv;
        private System.Windows.Forms.Button AdaugGrActiv;
        private System.Windows.Forms.Button button5;
    }
}

