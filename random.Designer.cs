namespace taistra
{
    partial class random
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
            this.labeltext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labeltext.ForeColor = System.Drawing.Color.LightCoral;
            this.labeltext.Location = new System.Drawing.Point(35, 38);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(0, 23);
            this.labeltext.TabIndex = 0;
            // 
            // random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(452, 281);
            this.Controls.Add(this.labeltext);
            this.Name = "random";
            this.Text = "random";
            this.Load += new System.EventHandler(this.random_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltext;
    }
}