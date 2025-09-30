namespace hastaTakipSistemi
{
    partial class frmIstatistic
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamHasta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYasOrtalama = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErkekSayi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKadinSayi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExSayi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87952F));
            this.tableLayoutPanel1.Controls.Add(this.lblExSayi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblKadinSayi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblErkekSayi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYasOrtalama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblToplamHasta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1270, 120);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Takip Sistemi V01-İstatistikler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Kayıtlı Hasta Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamHasta
            // 
            this.lblToplamHasta.AutoSize = true;
            this.lblToplamHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHasta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToplamHasta.Location = new System.Drawing.Point(633, 0);
            this.lblToplamHasta.Name = "lblToplamHasta";
            this.lblToplamHasta.Size = new System.Drawing.Size(622, 90);
            this.lblToplamHasta.TabIndex = 2;
            this.lblToplamHasta.Text = "00";
            this.lblToplamHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(624, 90);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hastaların Yaş Ortalaması";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYasOrtalama
            // 
            this.lblYasOrtalama.AutoSize = true;
            this.lblYasOrtalama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYasOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasOrtalama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYasOrtalama.Location = new System.Drawing.Point(633, 90);
            this.lblYasOrtalama.Name = "lblYasOrtalama";
            this.lblYasOrtalama.Size = new System.Drawing.Size(622, 90);
            this.lblYasOrtalama.TabIndex = 4;
            this.lblYasOrtalama.Text = "00";
            this.lblYasOrtalama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(624, 90);
            this.label6.TabIndex = 5;
            this.label6.Text = "Erkek Hasta Sayısı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErkekSayi
            // 
            this.lblErkekSayi.AutoSize = true;
            this.lblErkekSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErkekSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErkekSayi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErkekSayi.Location = new System.Drawing.Point(633, 180);
            this.lblErkekSayi.Name = "lblErkekSayi";
            this.lblErkekSayi.Size = new System.Drawing.Size(622, 90);
            this.lblErkekSayi.TabIndex = 6;
            this.lblErkekSayi.Text = "00";
            this.lblErkekSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(624, 90);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kadın Hasta Sayısı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKadinSayi
            // 
            this.lblKadinSayi.AutoSize = true;
            this.lblKadinSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKadinSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadinSayi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKadinSayi.Location = new System.Drawing.Point(633, 270);
            this.lblKadinSayi.Name = "lblKadinSayi";
            this.lblKadinSayi.Size = new System.Drawing.Size(622, 90);
            this.lblKadinSayi.TabIndex = 8;
            this.lblKadinSayi.Text = "00";
            this.lblKadinSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(3, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(624, 91);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ex Hasta Sayısı";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExSayi
            // 
            this.lblExSayi.AutoSize = true;
            this.lblExSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExSayi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExSayi.Location = new System.Drawing.Point(633, 360);
            this.lblExSayi.Name = "lblExSayi";
            this.lblExSayi.Size = new System.Drawing.Size(622, 91);
            this.lblExSayi.TabIndex = 10;
            this.lblExSayi.Text = "00";
            this.lblExSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIstatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1270, 570);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(1288, 617);
            this.Name = "frmIstatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIstatistic";
            this.Load += new System.EventHandler(this.frmIstatistic_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYasOrtalama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamHasta;
        private System.Windows.Forms.Label lblErkekSayi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExSayi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblKadinSayi;
        private System.Windows.Forms.Label label8;
    }
}