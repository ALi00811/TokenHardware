namespace UserInterFace.Forms
{
    partial class frmActivition
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
            this.btnActive = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtSID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLicense = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.statusFooter = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSID = new DevComponents.DotNetBar.LabelX();
            this.lblKey = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActive
            // 
            this.btnActive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActive.Location = new System.Drawing.Point(224, 199);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(114, 37);
            this.btnActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActive.TabIndex = 0;
            this.btnActive.Text = "Active";
            this.btnActive.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(12, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSID
            // 
            // 
            // 
            // 
            this.txtSID.Border.Class = "TextBoxBorder";
            this.txtSID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSID.Location = new System.Drawing.Point(76, 32);
            this.txtSID.Multiline = true;
            this.txtSID.Name = "txtSID";
            this.txtSID.PreventEnterBeep = true;
            this.txtSID.Size = new System.Drawing.Size(179, 57);
            this.txtSID.TabIndex = 1;
            // 
            // txtLicense
            // 
            // 
            // 
            // 
            this.txtLicense.Border.Class = "TextBoxBorder";
            this.txtLicense.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicense.Location = new System.Drawing.Point(76, 95);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.PreventEnterBeep = true;
            this.txtLicense.Size = new System.Drawing.Size(179, 48);
            this.txtLicense.TabIndex = 1;
            // 
            // statusFooter
            // 
            this.statusFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusFooter.Location = new System.Drawing.Point(0, 239);
            this.statusFooter.Name = "statusFooter";
            this.statusFooter.Size = new System.Drawing.Size(357, 22);
            this.statusFooter.TabIndex = 2;
            this.statusFooter.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 17);
            this.lblStatus.Text = "Please Enter License Key";
            // 
            // lblSID
            // 
            // 
            // 
            // 
            this.lblSID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSID.Location = new System.Drawing.Point(23, 48);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(75, 23);
            this.lblSID.TabIndex = 3;
            this.lblSID.Text = "SID:";
            // 
            // lblKey
            // 
            // 
            // 
            // 
            this.lblKey.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKey.Location = new System.Drawing.Point(23, 108);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(75, 23);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Key :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 16);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Controls.Add(this.txtLicense);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.lblSID);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // frmActivition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusFooter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActivition";
            this.Load += new System.EventHandler(this.frmActivition_Load);
            this.statusFooter.ResumeLayout(false);
            this.statusFooter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnActive;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLicense;
        private System.Windows.Forms.StatusStrip statusFooter;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private DevComponents.DotNetBar.LabelX lblSID;
        private DevComponents.DotNetBar.LabelX lblKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}