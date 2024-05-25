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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCreateNote = new System.Windows.Forms.PictureBox();
            this.buttonViewNotes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "View Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Create Note";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hub.Properties.Resources.back_button;
            this.pictureBox1.Location = new System.Drawing.Point(202, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.HubButton_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // buttonCreateNote
            // 
            this.buttonCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNote.Image = global::Hub.Properties.Resources.create1;
            this.buttonCreateNote.Location = new System.Drawing.Point(64, 112);
            this.buttonCreateNote.Name = "buttonCreateNote";
            this.buttonCreateNote.Size = new System.Drawing.Size(61, 57);
            this.buttonCreateNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCreateNote.TabIndex = 11;
            this.buttonCreateNote.TabStop = false;
            this.buttonCreateNote.Click += new System.EventHandler(this.buttonCreateNote_Click);
            this.buttonCreateNote.MouseEnter += new System.EventHandler(this.buttonCreateNote_MouseEnter);
            this.buttonCreateNote.MouseLeave += new System.EventHandler(this.buttonCreateNote_MouseLeave);
            // 
            // buttonViewNotes
            // 
            this.buttonViewNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewNotes.Image = global::Hub.Properties.Resources.search;
            this.buttonViewNotes.Location = new System.Drawing.Point(66, 40);
            this.buttonViewNotes.Name = "buttonViewNotes";
            this.buttonViewNotes.Size = new System.Drawing.Size(59, 57);
            this.buttonViewNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonViewNotes.TabIndex = 9;
            this.buttonViewNotes.TabStop = false;
            this.buttonViewNotes.Click += new System.EventHandler(this.buttonViewNotes_Click);
            this.buttonViewNotes.MouseEnter += new System.EventHandler(this.buttonViewNotes_MouseEnter);
            this.buttonViewNotes.MouseLeave += new System.EventHandler(this.buttonViewNotes_MouseLeave);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonViewNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox buttonViewNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttonCreateNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

