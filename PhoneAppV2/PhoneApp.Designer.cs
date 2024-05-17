namespace PhoneAppV2
{
    partial class PhoneApp
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
            this.components = new System.ComponentModel.Container();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contactPreview = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Editscreen = new System.Windows.Forms.TabPage();
            this.contactAdder = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRecorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton = new System.Windows.Forms.Button();
            this.AddBackButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.AddSaveButton = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.PhoneNumberTxt = new System.Windows.Forms.MaskedTextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.AddEmail = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddDescription = new System.Windows.Forms.TextBox();
            this.AddAddress = new System.Windows.Forms.TextBox();
            this.AddSurname = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.TextBox();
            this.TabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Editscreen.SuspendLayout();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.tabPage1);
            this.TabMenu.Controls.Add(this.tabPage2);
            this.TabMenu.Controls.Add(this.Editscreen);
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(276, 489);
            this.TabMenu.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contactPreview);
            this.tabPage1.Controls.Add(this.contactAdder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contactPreview
            // 
            this.contactPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contactPreview.HideSelection = false;
            this.contactPreview.Location = new System.Drawing.Point(3, 3);
            this.contactPreview.Name = "contactPreview";
            this.contactPreview.Size = new System.Drawing.Size(262, 405);
            this.contactPreview.TabIndex = 0;
            this.contactPreview.UseCompatibleStateImageBehavior = false;
            this.contactPreview.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddEmail);
            this.tabPage2.Controls.Add(this.AddPhone);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.AddDescription);
            this.tabPage2.Controls.Add(this.AddAddress);
            this.tabPage2.Controls.Add(this.AddSurname);
            this.tabPage2.Controls.Add(this.AddName);
            this.tabPage2.Controls.Add(this.AddSaveButton);
            this.tabPage2.Controls.Add(this.AddBackButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Contact";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Editscreen
            // 
            this.Editscreen.Controls.Add(this.EmailTxt);
            this.Editscreen.Controls.Add(this.PhoneNumberTxt);
            this.Editscreen.Controls.Add(this.lblEmail);
            this.Editscreen.Controls.Add(this.lblDescription);
            this.Editscreen.Controls.Add(this.lblAddress);
            this.Editscreen.Controls.Add(this.lblPhoneNumber);
            this.Editscreen.Controls.Add(this.lblSurname);
            this.Editscreen.Controls.Add(this.lblName);
            this.Editscreen.Controls.Add(this.DescriptionTxt);
            this.Editscreen.Controls.Add(this.AddressTxt);
            this.Editscreen.Controls.Add(this.SurnameTxt);
            this.Editscreen.Controls.Add(this.NameTxt);
            this.Editscreen.Controls.Add(this.backButton);
            this.Editscreen.Controls.Add(this.saveButton);
            this.Editscreen.Location = new System.Drawing.Point(4, 22);
            this.Editscreen.Name = "Editscreen";
            this.Editscreen.Padding = new System.Windows.Forms.Padding(3);
            this.Editscreen.Size = new System.Drawing.Size(268, 463);
            this.Editscreen.TabIndex = 2;
            this.Editscreen.Text = "EditScreen";
            this.Editscreen.UseVisualStyleBackColor = true;
            // 
            // contactAdder
            // 
            this.contactAdder.Location = new System.Drawing.Point(3, 408);
            this.contactAdder.Name = "contactAdder";
            this.contactAdder.Size = new System.Drawing.Size(265, 52);
            this.contactAdder.TabIndex = 6;
            this.contactAdder.Text = "Add Contact";
            this.contactAdder.UseVisualStyleBackColor = true;
            this.contactAdder.Click += new System.EventHandler(this.contactAdder_Click);
            // 
            // options
            // 
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRecorToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(148, 48);
            // 
            // editRecorToolStripMenuItem
            // 
            this.editRecorToolStripMenuItem.Name = "editRecorToolStripMenuItem";
            this.editRecorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editRecorToolStripMenuItem.Text = "Edit Record";
            this.editRecorToolStripMenuItem.Click += new System.EventHandler(this.editRecorToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(46, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 37);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddBackButton
            // 
            this.AddBackButton.Location = new System.Drawing.Point(46, 365);
            this.AddBackButton.Name = "AddBackButton";
            this.AddBackButton.Size = new System.Drawing.Size(74, 37);
            this.AddBackButton.TabIndex = 40;
            this.AddBackButton.Text = "Back";
            this.AddBackButton.UseVisualStyleBackColor = true;
            this.AddBackButton.Click += new System.EventHandler(this.AddBackButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(158, 365);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 37);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddSaveButton
            // 
            this.AddSaveButton.Location = new System.Drawing.Point(158, 365);
            this.AddSaveButton.Name = "AddSaveButton";
            this.AddSaveButton.Size = new System.Drawing.Size(74, 37);
            this.AddSaveButton.TabIndex = 41;
            this.AddSaveButton.Text = "Save";
            this.AddSaveButton.UseVisualStyleBackColor = true;
            this.AddSaveButton.Click += new System.EventHandler(this.AddSaveButton_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(98, 34);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(134, 20);
            this.NameTxt.TabIndex = 40;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(98, 64);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(134, 20);
            this.SurnameTxt.TabIndex = 41;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(98, 142);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(134, 71);
            this.AddressTxt.TabIndex = 42;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(98, 259);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(134, 51);
            this.DescriptionTxt.TabIndex = 43;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(43, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 45;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 106);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(47, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 47;
            this.lblAddress.Text = "Address";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 262);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 48;
            this.lblDescription.Text = "Description";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(48, 226);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "E-mail";
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.Location = new System.Drawing.Point(98, 106);
            this.PhoneNumberTxt.Mask = "(999) 000-0000";
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(134, 20);
            this.PhoneNumberTxt.TabIndex = 50;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(98, 223);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(134, 20);
            this.EmailTxt.TabIndex = 51;
            // 
            // AddEmail
            // 
            this.AddEmail.Location = new System.Drawing.Point(98, 223);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(134, 20);
            this.AddEmail.TabIndex = 63;
            // 
            // AddPhone
            // 
            this.AddPhone.Location = new System.Drawing.Point(98, 106);
            this.AddPhone.Mask = "(999) 000-0000";
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(134, 20);
            this.AddPhone.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Name";
            // 
            // AddDescription
            // 
            this.AddDescription.Location = new System.Drawing.Point(98, 259);
            this.AddDescription.Multiline = true;
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(134, 51);
            this.AddDescription.TabIndex = 55;
            // 
            // AddAddress
            // 
            this.AddAddress.Location = new System.Drawing.Point(98, 142);
            this.AddAddress.Multiline = true;
            this.AddAddress.Name = "AddAddress";
            this.AddAddress.Size = new System.Drawing.Size(134, 71);
            this.AddAddress.TabIndex = 54;
            // 
            // AddSurname
            // 
            this.AddSurname.Location = new System.Drawing.Point(98, 64);
            this.AddSurname.Name = "AddSurname";
            this.AddSurname.Size = new System.Drawing.Size(134, 20);
            this.AddSurname.TabIndex = 53;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(98, 34);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(134, 20);
            this.AddName.TabIndex = 52;
            // 
            // PhoneApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 489);
            this.Controls.Add(this.TabMenu);
            this.Name = "PhoneApp";
            this.Text = "PhoneApp";
            this.Load += new System.EventHandler(this.PhoneApp_Load);
            this.TabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Editscreen.ResumeLayout(false);
            this.Editscreen.PerformLayout();
            this.options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView contactPreview;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Editscreen;
        private System.Windows.Forms.Button contactAdder;
        private System.Windows.Forms.ContextMenuStrip options;
        private System.Windows.Forms.ToolStripMenuItem editRecorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.TextBox AddEmail;
        private System.Windows.Forms.MaskedTextBox AddPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddDescription;
        private System.Windows.Forms.TextBox AddAddress;
        private System.Windows.Forms.TextBox AddSurname;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Button AddSaveButton;
        private System.Windows.Forms.Button AddBackButton;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.MaskedTextBox PhoneNumberTxt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
    }
}

