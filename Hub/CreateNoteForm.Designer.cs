namespace NoteBook
{
    partial class CreateNoteForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSaveNote = new System.Windows.Forms.Button();
            this.HubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(35, 49);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(471, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(35, 88);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(471, 156);
            this.textBoxContent.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(32, 28);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            // 
            // buttonSaveNote
            // 
            this.buttonSaveNote.Location = new System.Drawing.Point(35, 259);
            this.buttonSaveNote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveNote.Name = "buttonSaveNote";
            this.buttonSaveNote.Size = new System.Drawing.Size(107, 31);
            this.buttonSaveNote.TabIndex = 5;
            this.buttonSaveNote.Text = "Save Note";
            this.buttonSaveNote.UseVisualStyleBackColor = true;
            this.buttonSaveNote.Click += new System.EventHandler(this.buttonSaveNote_Click);
            // 
            // HubButton
            // 
            this.HubButton.Location = new System.Drawing.Point(366, 255);
            this.HubButton.Name = "HubButton";
            this.HubButton.Size = new System.Drawing.Size(109, 38);
            this.HubButton.TabIndex = 9;
            this.HubButton.Text = "Back";
            this.HubButton.UseVisualStyleBackColor = true;
            this.HubButton.Click += new System.EventHandler(this.HubButton_Click);
            // 
            // CreateNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 312);
            this.Controls.Add(this.HubButton);
            this.Controls.Add(this.buttonSaveNote);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSaveNote;
        private System.Windows.Forms.Button HubButton;
    }
}