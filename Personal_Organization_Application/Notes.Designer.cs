namespace Hub
{
    partial class Notes
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
            this.buttonViewNotes = new System.Windows.Forms.Button();
            this.buttonCreateNote = new System.Windows.Forms.Button();
            this.HubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewNotes
            // 
            this.buttonViewNotes.Location = new System.Drawing.Point(35, 25);
            this.buttonViewNotes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewNotes.Name = "buttonViewNotes";
            this.buttonViewNotes.Size = new System.Drawing.Size(131, 36);
            this.buttonViewNotes.TabIndex = 0;
            this.buttonViewNotes.Text = "View Notes";
            this.buttonViewNotes.UseVisualStyleBackColor = true;
            this.buttonViewNotes.Click += new System.EventHandler(this.buttonViewNotes_Click);
            // 
            // buttonCreateNote
            // 
            this.buttonCreateNote.Location = new System.Drawing.Point(35, 79);
            this.buttonCreateNote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateNote.Name = "buttonCreateNote";
            this.buttonCreateNote.Size = new System.Drawing.Size(131, 36);
            this.buttonCreateNote.TabIndex = 1;
            this.buttonCreateNote.Text = "Create Note";
            this.buttonCreateNote.UseVisualStyleBackColor = true;
            this.buttonCreateNote.Click += new System.EventHandler(this.buttonCreateNote_Click);
            // 
            // HubButton
            // 
            this.HubButton.Location = new System.Drawing.Point(36, 129);
            this.HubButton.Name = "HubButton";
            this.HubButton.Size = new System.Drawing.Size(130, 52);
            this.HubButton.TabIndex = 8;
            this.HubButton.Text = "Back HuB";
            this.HubButton.UseVisualStyleBackColor = true;
            this.HubButton.Click += new System.EventHandler(this.HubButton_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.HubButton);
            this.Controls.Add(this.buttonCreateNote);
            this.Controls.Add(this.buttonViewNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewNotes;
        private System.Windows.Forms.Button buttonCreateNote;
        private System.Windows.Forms.Button HubButton;
    }
}

