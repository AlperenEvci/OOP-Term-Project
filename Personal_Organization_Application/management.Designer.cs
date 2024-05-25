namespace Hub
{
    partial class management
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statü = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İsim,
            this.Soyisim,
            this.TelefonNo,
            this.Adres,
            this.Email,
            this.şifre,
            this.statü});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // İsim
            // 
            this.İsim.HeaderText = "İsim";
            this.İsim.MinimumWidth = 6;
            this.İsim.Name = "İsim";
            this.İsim.Width = 125;
            // 
            // Soyisim
            // 
            this.Soyisim.HeaderText = "Soyisim";
            this.Soyisim.MinimumWidth = 6;
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Width = 125;
            // 
            // TelefonNo
            // 
            this.TelefonNo.HeaderText = "Telefon Numarası";
            this.TelefonNo.MinimumWidth = 6;
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Width = 125;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.MinimumWidth = 6;
            this.Adres.Name = "Adres";
            this.Adres.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // şifre
            // 
            this.şifre.HeaderText = "Şifre";
            this.şifre.MinimumWidth = 6;
            this.şifre.Name = "şifre";
            this.şifre.Width = 125;
            // 
            // statü
            // 
            this.statü.HeaderText = "Statü";
            this.statü.Items.AddRange(new object[] {
            "admin",
            "user",
            "parttime user"});
            this.statü.MinimumWidth = 6;
            this.statü.Name = "statü";
            this.statü.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statü.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statü.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(514, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Değişiklikleri Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hub.Properties.Resources.back_button;
            this.pictureBox1.Location = new System.Drawing.Point(432, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.HubButton_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "management";
            this.Load += new System.EventHandler(this.management_Load);
            this.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn şifre;
        private System.Windows.Forms.DataGridViewComboBoxColumn statü;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}