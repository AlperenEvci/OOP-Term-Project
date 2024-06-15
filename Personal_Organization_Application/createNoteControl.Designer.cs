namespace Hub
{
    partial class createNoteControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonSaveNote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveNote)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Save Note";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(38, 52);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(52, 18);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxContent.ForeColor = System.Drawing.Color.White;
            this.textBoxContent.Location = new System.Drawing.Point(41, 112);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(471, 156);
            this.textBoxContent.TabIndex = 17;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTitle.Location = new System.Drawing.Point(41, 73);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(471, 26);
            this.textBoxTitle.TabIndex = 16;
            // 
            // buttonSaveNote
            // 
            this.buttonSaveNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.buttonSaveNote.Image = global::Hub.Properties.Resources.save_note_icon;
            this.buttonSaveNote.Location = new System.Drawing.Point(41, 276);
            this.buttonSaveNote.Name = "buttonSaveNote";
            this.buttonSaveNote.Size = new System.Drawing.Size(47, 41);
            this.buttonSaveNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSaveNote.TabIndex = 19;
            this.buttonSaveNote.TabStop = false;
            this.buttonSaveNote.Click += new System.EventHandler(this.buttonSaveNote_Click);
            this.buttonSaveNote.MouseEnter += new System.EventHandler(this.buttonSaveNote_MouseEnter);
            this.buttonSaveNote.MouseLeave += new System.EventHandler(this.buttonSaveNote_MouseLeave);
            // 
            // createNoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveNote);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "createNoteControl";
            this.Size = new System.Drawing.Size(550, 379);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttonSaveNote;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}
