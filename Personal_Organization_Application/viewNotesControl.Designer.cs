namespace Hub
{
    partial class viewNotesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            this.buttonSaveChanges = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Delete Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Save Changes";
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxContent.ForeColor = System.Drawing.Color.White;
            this.textBoxContent.Location = new System.Drawing.Point(290, 93);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(355, 242);
            this.textBoxContent.TabIndex = 18;
            this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_TextChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTitle.Location = new System.Drawing.Point(290, 51);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(355, 26);
            this.textBoxTitle.TabIndex = 17;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.listBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxNotes.ForeColor = System.Drawing.Color.White;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 20;
            this.listBoxNotes.Location = new System.Drawing.Point(41, 51);
            this.listBoxNotes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(221, 284);
            this.listBoxNotes.TabIndex = 16;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(287, 31);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(52, 18);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "Title:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.buttonDelete.Image = global::Hub.Properties.Resources.delete_icon;
            this.buttonDelete.Location = new System.Drawing.Point(41, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(47, 41);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonDelete_MouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonDelete_MouseLeave);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.buttonSaveChanges.Image = global::Hub.Properties.Resources.save_note_icon;
            this.buttonSaveChanges.Location = new System.Drawing.Point(290, 374);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(47, 41);
            this.buttonSaveChanges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSaveChanges.TabIndex = 19;
            this.buttonSaveChanges.TabStop = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            this.buttonSaveChanges.MouseEnter += new System.EventHandler(this.buttonSaveChanges_MouseEnter);
            this.buttonSaveChanges.MouseLeave += new System.EventHandler(this.buttonSaveChanges_MouseLeave);
            // 
            // viewNotesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listBoxNotes);
            this.Name = "viewNotesControl";
            this.Size = new System.Drawing.Size(670, 467);
            this.VisibleChanged += new System.EventHandler(this.viewNotesControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttonSaveChanges;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Label labelTitle;
    }
}
