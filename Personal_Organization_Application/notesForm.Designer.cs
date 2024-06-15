namespace Hub
{
    partial class notesForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createNoteControl1 = new createNoteControl();
            this.viewNotesControl1 = new viewNotesControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCreateNote = new System.Windows.Forms.PictureBox();
            this.buttonViewNotes = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Create Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "View Notes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCreateNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonViewNotes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 630);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.createNoteControl1);
            this.panel2.Controls.Add(this.viewNotesControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 630);
            this.panel2.TabIndex = 21;
            // 
            // createNoteControl1
            // 
            this.createNoteControl1.Location = new System.Drawing.Point(72, 83);
            this.createNoteControl1.Name = "createNoteControl1";
            this.createNoteControl1.Size = new System.Drawing.Size(546, 451);
            this.createNoteControl1.TabIndex = 1;
            this.createNoteControl1.Visible = false;
            // 
            // viewNotesControl1
            // 
            this.viewNotesControl1.Location = new System.Drawing.Point(0, 67);
            this.viewNotesControl1.Name = "viewNotesControl1";
            this.viewNotesControl1.Size = new System.Drawing.Size(670, 467);
            this.viewNotesControl1.TabIndex = 0;
            this.viewNotesControl1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hub.Properties.Resources.back2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.HubButton_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // buttonCreateNote
            // 
            this.buttonCreateNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.buttonCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNote.Image = global::Hub.Properties.Resources.add_notes_icon;
            this.buttonCreateNote.Location = new System.Drawing.Point(19, 275);
            this.buttonCreateNote.Name = "buttonCreateNote";
            this.buttonCreateNote.Size = new System.Drawing.Size(61, 57);
            this.buttonCreateNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCreateNote.TabIndex = 17;
            this.buttonCreateNote.TabStop = false;
            this.buttonCreateNote.Click += new System.EventHandler(this.buttonCreateNote_Click);
            this.buttonCreateNote.MouseEnter += new System.EventHandler(this.buttonCreateNote_MouseEnter);
            this.buttonCreateNote.MouseLeave += new System.EventHandler(this.buttonCreateNote_MouseLeave);
            // 
            // buttonViewNotes
            // 
            this.buttonViewNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.buttonViewNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewNotes.Image = global::Hub.Properties.Resources.view_note_icon1;
            this.buttonViewNotes.Location = new System.Drawing.Point(19, 178);
            this.buttonViewNotes.Name = "buttonViewNotes";
            this.buttonViewNotes.Size = new System.Drawing.Size(59, 57);
            this.buttonViewNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonViewNotes.TabIndex = 15;
            this.buttonViewNotes.TabStop = false;
            this.buttonViewNotes.Click += new System.EventHandler(this.buttonViewNotes_Click);
            this.buttonViewNotes.MouseEnter += new System.EventHandler(this.buttonViewNotes_MouseEnter);
            this.buttonViewNotes.MouseLeave += new System.EventHandler(this.buttonViewNotes_MouseLeave);
            // 
            // notesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "notesForm";
            this.Size = new System.Drawing.Size(893, 630);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox buttonCreateNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttonViewNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private createNoteControl createNoteControl1;
        private viewNotesControl viewNotesControl1;
    }
}
