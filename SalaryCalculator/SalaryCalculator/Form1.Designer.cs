namespace SalaryCalculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBoxLanguage = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDegree = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDuty = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxExp = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxLanguage
            // 
            this.checkedListBoxLanguage.FormattingEnabled = true;
            this.checkedListBoxLanguage.HorizontalScrollbar = true;
            this.checkedListBoxLanguage.Location = new System.Drawing.Point(23, 143);
            this.checkedListBoxLanguage.Name = "checkedListBoxLanguage";
            this.checkedListBoxLanguage.Size = new System.Drawing.Size(337, 79);
            this.checkedListBoxLanguage.TabIndex = 9;
            this.checkedListBoxLanguage.SelectedValueChanged += new System.EventHandler(this.checkedListBoxLanguage_SelectedValueChanged);
            // 
            // checkedListBoxDegree
            // 
            this.checkedListBoxDegree.FormattingEnabled = true;
            this.checkedListBoxDegree.HorizontalScrollbar = true;
            this.checkedListBoxDegree.Location = new System.Drawing.Point(23, 285);
            this.checkedListBoxDegree.Name = "checkedListBoxDegree";
            this.checkedListBoxDegree.Size = new System.Drawing.Size(337, 79);
            this.checkedListBoxDegree.TabIndex = 10;
            // 
            // checkedListBoxDuty
            // 
            this.checkedListBoxDuty.FormattingEnabled = true;
            this.checkedListBoxDuty.HorizontalScrollbar = true;
            this.checkedListBoxDuty.Location = new System.Drawing.Point(439, 37);
            this.checkedListBoxDuty.Name = "checkedListBoxDuty";
            this.checkedListBoxDuty.Size = new System.Drawing.Size(326, 79);
            this.checkedListBoxDuty.TabIndex = 11;
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.HorizontalScrollbar = true;
            this.checkedListBoxStatus.Location = new System.Drawing.Point(439, 146);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(326, 79);
            this.checkedListBoxStatus.TabIndex = 12;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(23, 37);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(222, 20);
            this.textBoxCity.TabIndex = 13;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // comboBoxExp
            // 
            this.comboBoxExp.FormattingEnabled = true;
            this.comboBoxExp.Location = new System.Drawing.Point(23, 84);
            this.comboBoxExp.Name = "comboBoxExp";
            this.comboBoxExp.Size = new System.Drawing.Size(222, 21);
            this.comboBoxExp.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 228);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Experiment Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Language Proficiency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Academic Degree";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(436, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Management Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(436, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Marital Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBoxExp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Controls.Add(this.checkedListBoxStatus);
            this.panel1.Controls.Add(this.checkedListBoxDuty);
            this.panel1.Controls.Add(this.checkedListBoxDegree);
            this.panel1.Controls.Add(this.checkedListBoxLanguage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 393);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguage;
        private System.Windows.Forms.CheckedListBox checkedListBoxDegree;
        private System.Windows.Forms.CheckedListBox checkedListBoxDuty;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}

