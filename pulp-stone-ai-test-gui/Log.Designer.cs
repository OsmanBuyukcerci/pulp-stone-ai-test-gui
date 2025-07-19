namespace pulp_stone_ai_test_gui
{
    partial class Log
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
            this.lstbox_log = new System.Windows.Forms.ListBox();
            this.lbl_log_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbox_log
            // 
            this.lstbox_log.FormattingEnabled = true;
            this.lstbox_log.Location = new System.Drawing.Point(12, 41);
            this.lstbox_log.Name = "lstbox_log";
            this.lstbox_log.Size = new System.Drawing.Size(518, 277);
            this.lstbox_log.TabIndex = 0;
            // 
            // lbl_log_header
            // 
            this.lbl_log_header.AutoSize = true;
            this.lbl_log_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_log_header.Location = new System.Drawing.Point(12, 14);
            this.lbl_log_header.Name = "lbl_log_header";
            this.lbl_log_header.Size = new System.Drawing.Size(45, 24);
            this.lbl_log_header.TabIndex = 1;
            this.lbl_log_header.Text = "Log";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 328);
            this.Controls.Add(this.lbl_log_header);
            this.Controls.Add(this.lstbox_log);
            this.Name = "Log";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_log;
        private System.Windows.Forms.Label lbl_log_header;
    }
}