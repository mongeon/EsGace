namespace EsGace.Forms
{
    partial class APropos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APropos));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lnkSiteWeb = new System.Windows.Forms.LinkLabel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tipPropos = new System.Windows.Forms.ToolTip(this.components);
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AccessibleDescription = null;
            this.tableLayoutPanel.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackgroundImage = null;
            this.tableLayoutPanel.Controls.Add(this.lnkSiteWeb, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 2, 5);
            this.tableLayoutPanel.Font = null;
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tipPropos.SetToolTip(this.tableLayoutPanel, resources.GetString("tableLayoutPanel.ToolTip"));
            // 
            // lnkSiteWeb
            // 
            this.lnkSiteWeb.AccessibleDescription = null;
            this.lnkSiteWeb.AccessibleName = null;
            resources.ApplyResources(this.lnkSiteWeb, "lnkSiteWeb");
            this.lnkSiteWeb.Font = null;
            this.lnkSiteWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSiteWeb.Name = "lnkSiteWeb";
            this.lnkSiteWeb.TabStop = true;
            this.tipPropos.SetToolTip(this.lnkSiteWeb, resources.GetString("lnkSiteWeb.ToolTip"));
            this.lnkSiteWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSiteWeb_LinkClicked);
            // 
            // labelProductName
            // 
            this.labelProductName.AccessibleDescription = null;
            this.labelProductName.AccessibleName = null;
            resources.ApplyResources(this.labelProductName, "labelProductName");
            this.tableLayoutPanel.SetColumnSpan(this.labelProductName, 2);
            this.labelProductName.Font = null;
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.tipPropos.SetToolTip(this.labelProductName, resources.GetString("labelProductName.ToolTip"));
            // 
            // labelVersion
            // 
            this.labelVersion.AccessibleDescription = null;
            this.labelVersion.AccessibleName = null;
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 2);
            this.labelVersion.Font = null;
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.tipPropos.SetToolTip(this.labelVersion, resources.GetString("labelVersion.ToolTip"));
            // 
            // labelCopyright
            // 
            this.labelCopyright.AccessibleDescription = null;
            this.labelCopyright.AccessibleName = null;
            resources.ApplyResources(this.labelCopyright, "labelCopyright");
            this.tableLayoutPanel.SetColumnSpan(this.labelCopyright, 2);
            this.labelCopyright.Font = null;
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.tipPropos.SetToolTip(this.labelCopyright, resources.GetString("labelCopyright.ToolTip"));
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AccessibleDescription = null;
            this.labelCompanyName.AccessibleName = null;
            resources.ApplyResources(this.labelCompanyName, "labelCompanyName");
            this.tableLayoutPanel.SetColumnSpan(this.labelCompanyName, 2);
            this.labelCompanyName.Font = null;
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.tipPropos.SetToolTip(this.labelCompanyName, resources.GetString("labelCompanyName.ToolTip"));
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AccessibleDescription = null;
            this.textBoxDescription.AccessibleName = null;
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.BackgroundImage = null;
            this.tableLayoutPanel.SetColumnSpan(this.textBoxDescription, 2);
            this.textBoxDescription.Font = null;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.TabStop = false;
            this.tipPropos.SetToolTip(this.textBoxDescription, resources.GetString("textBoxDescription.ToolTip"));
            // 
            // okButton
            // 
            this.okButton.AccessibleDescription = null;
            this.okButton.AccessibleName = null;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.BackgroundImage = null;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Font = null;
            this.okButton.Name = "okButton";
            this.tipPropos.SetToolTip(this.okButton, resources.GetString("okButton.ToolTip"));
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.AccessibleDescription = null;
            this.logoPictureBox.AccessibleName = null;
            resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
            this.logoPictureBox.BackgroundImage = null;
            this.logoPictureBox.Font = null;
            this.logoPictureBox.ImageLocation = null;
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.TabStop = false;
            this.tipPropos.SetToolTip(this.logoPictureBox, resources.GetString("logoPictureBox.ToolTip"));
            // 
            // APropos
            // 
            this.AcceptButton = this.okButton;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APropos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tipPropos.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel lnkSiteWeb;
        private System.Windows.Forms.ToolTip tipPropos;
    }
}
