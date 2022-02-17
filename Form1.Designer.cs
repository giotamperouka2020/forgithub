namespace taistra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.feedbtn = new System.Windows.Forms.Button();
            this.appbtn = new System.Windows.Forms.Button();
            this.planbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelCenterPage = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Controls.Add(this.feedbtn);
            this.panel1.Controls.Add(this.appbtn);
            this.panel1.Controls.Add(this.planbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 488);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(63, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 31);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(202, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 93);
            this.panel3.TabIndex = 5;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Exitbtn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Exitbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.Location = new System.Drawing.Point(0, 276);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(203, 54);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // feedbtn
            // 
            this.feedbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.feedbtn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.feedbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.feedbtn.Image = ((System.Drawing.Image)(resources.GetObject("feedbtn.Image")));
            this.feedbtn.Location = new System.Drawing.Point(0, 216);
            this.feedbtn.Name = "feedbtn";
            this.feedbtn.Size = new System.Drawing.Size(203, 54);
            this.feedbtn.TabIndex = 3;
            this.feedbtn.Text = "Feeder";
            this.feedbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.feedbtn.UseVisualStyleBackColor = false;
            this.feedbtn.Click += new System.EventHandler(this.feedbtn_Click);
            // 
            // appbtn
            // 
            this.appbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.appbtn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.appbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.appbtn.Image = ((System.Drawing.Image)(resources.GetObject("appbtn.Image")));
            this.appbtn.Location = new System.Drawing.Point(0, 156);
            this.appbtn.Name = "appbtn";
            this.appbtn.Size = new System.Drawing.Size(203, 54);
            this.appbtn.TabIndex = 2;
            this.appbtn.Text = "Appliances";
            this.appbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appbtn.UseVisualStyleBackColor = false;
            this.appbtn.Click += new System.EventHandler(this.appbtn_Click);
            // 
            // planbtn
            // 
            this.planbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.planbtn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.planbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.planbtn.Image = ((System.Drawing.Image)(resources.GetObject("planbtn.Image")));
            this.planbtn.Location = new System.Drawing.Point(0, 96);
            this.planbtn.Name = "planbtn";
            this.planbtn.Size = new System.Drawing.Size(203, 54);
            this.planbtn.TabIndex = 1;
            this.planbtn.Text = "Plan";
            this.planbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.planbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.planbtn.UseVisualStyleBackColor = false;
            this.planbtn.Click += new System.EventHandler(this.planbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 90);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(46, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelBar.Controls.Add(this.label1);
            this.panelBar.Location = new System.Drawing.Point(203, 1);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(780, 93);
            this.panelBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(283, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "META-XENIA";
            // 
            // PanelCenterPage
            // 
            this.PanelCenterPage.Location = new System.Drawing.Point(205, 90);
            this.PanelCenterPage.Name = "PanelCenterPage";
            this.PanelCenterPage.Size = new System.Drawing.Size(780, 398);
            this.PanelCenterPage.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 491);
            this.Controls.Add(this.PanelCenterPage);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button feedbtn;
        private System.Windows.Forms.Button appbtn;
        private System.Windows.Forms.Button planbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelCenterPage;
        private System.Windows.Forms.Button button1;
    }
}

