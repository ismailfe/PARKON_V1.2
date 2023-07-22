namespace Parkon
{
    partial class Form_Yeni_MusteriBolum
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
            this.label11 = new System.Windows.Forms.Label();
            this.TB_MusteriFirma_No = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.B_OK = new System.Windows.Forms.Button();
            this.B_Iptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_MusteriBolum_Adi = new System.Windows.Forms.TextBox();
            this.CB_MusteriFirma_Adi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_MusteriBolum_No = new System.Windows.Forms.TextBox();
            this.TB_MusteriBolum_Not = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Durum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Müşteri Firma Adı :";
            // 
            // TB_MusteriFirma_No
            // 
            this.TB_MusteriFirma_No.Location = new System.Drawing.Point(123, 42);
            this.TB_MusteriFirma_No.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MusteriFirma_No.Name = "TB_MusteriFirma_No";
            this.TB_MusteriFirma_No.ReadOnly = true;
            this.TB_MusteriFirma_No.Size = new System.Drawing.Size(448, 22);
            this.TB_MusteriFirma_No.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Müşteri No :";
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(409, 171);
            this.B_OK.Margin = new System.Windows.Forms.Padding(4);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(80, 25);
            this.B_OK.TabIndex = 4;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // B_Iptal
            // 
            this.B_Iptal.Location = new System.Drawing.Point(491, 171);
            this.B_Iptal.Margin = new System.Windows.Forms.Padding(4);
            this.B_Iptal.Name = "B_Iptal";
            this.B_Iptal.Size = new System.Drawing.Size(80, 25);
            this.B_Iptal.TabIndex = 5;
            this.B_Iptal.Text = "İptal";
            this.B_Iptal.UseVisualStyleBackColor = true;
            this.B_Iptal.Click += new System.EventHandler(this.B_Iptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bölüm Adı :";
            // 
            // TB_MusteriBolum_Adi
            // 
            this.TB_MusteriBolum_Adi.Location = new System.Drawing.Point(123, 70);
            this.TB_MusteriBolum_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MusteriBolum_Adi.Name = "TB_MusteriBolum_Adi";
            this.TB_MusteriBolum_Adi.Size = new System.Drawing.Size(448, 22);
            this.TB_MusteriBolum_Adi.TabIndex = 2;
            this.TB_MusteriBolum_Adi.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Bolum_Adi_Validating);
            // 
            // CB_MusteriFirma_Adi
            // 
            this.CB_MusteriFirma_Adi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MusteriFirma_Adi.FormattingEnabled = true;
            this.CB_MusteriFirma_Adi.Location = new System.Drawing.Point(123, 9);
            this.CB_MusteriFirma_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.CB_MusteriFirma_Adi.Name = "CB_MusteriFirma_Adi";
            this.CB_MusteriFirma_Adi.Size = new System.Drawing.Size(448, 24);
            this.CB_MusteriFirma_Adi.TabIndex = 1;
            this.CB_MusteriFirma_Adi.SelectedIndexChanged += new System.EventHandler(this.CB_MusteriFirma_Adi_SelectedIndexChanged);
            this.CB_MusteriFirma_Adi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CB_MusteriFirma_Adi_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bölüm No :";
            // 
            // TB_MusteriBolum_No
            // 
            this.TB_MusteriBolum_No.Location = new System.Drawing.Point(123, 94);
            this.TB_MusteriBolum_No.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MusteriBolum_No.Name = "TB_MusteriBolum_No";
            this.TB_MusteriBolum_No.ReadOnly = true;
            this.TB_MusteriBolum_No.Size = new System.Drawing.Size(448, 22);
            this.TB_MusteriBolum_No.TabIndex = 23;
            // 
            // TB_MusteriBolum_Not
            // 
            this.TB_MusteriBolum_Not.Location = new System.Drawing.Point(123, 119);
            this.TB_MusteriBolum_Not.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MusteriBolum_Not.Multiline = true;
            this.TB_MusteriBolum_Not.Name = "TB_MusteriBolum_Not";
            this.TB_MusteriBolum_Not.Size = new System.Drawing.Size(448, 44);
            this.TB_MusteriBolum_Not.TabIndex = 3;
            this.TB_MusteriBolum_Not.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Bolum_Adi_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bölüm için Not :";
            // 
            // TB_Durum
            // 
            this.TB_Durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_Durum.Location = new System.Drawing.Point(12, 202);
            this.TB_Durum.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Durum.Multiline = true;
            this.TB_Durum.Name = "TB_Durum";
            this.TB_Durum.ReadOnly = true;
            this.TB_Durum.Size = new System.Drawing.Size(559, 36);
            this.TB_Durum.TabIndex = 23;
            // 
            // Form_Yeni_MusteriBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 242);
            this.Controls.Add(this.CB_MusteriFirma_Adi);
            this.Controls.Add(this.B_Iptal);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.TB_Durum);
            this.Controls.Add(this.TB_MusteriBolum_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_MusteriBolum_Not);
            this.Controls.Add(this.TB_MusteriBolum_Adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_MusteriFirma_No);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Yeni_MusteriBolum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri firma için yeni bölüm ekle";
            this.Load += new System.EventHandler(this.Form_Yeni_Musteri_Load);
            this.Shown += new System.EventHandler(this.Form_Yeni_MusteriBolum_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox TB_MusteriFirma_No;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button B_OK;
        public System.Windows.Forms.Button B_Iptal;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TB_MusteriBolum_Adi;
        private System.Windows.Forms.ComboBox CB_MusteriFirma_Adi;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_MusteriBolum_No;
        public System.Windows.Forms.TextBox TB_MusteriBolum_Not;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TB_Durum;
    }
}