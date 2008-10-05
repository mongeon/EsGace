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
            this.tlpRemerciements = new System.Windows.Forms.TableLayoutPanel();
            this.lnkTreeMap = new System.Windows.Forms.LinkLabel();
            this.lnkFamFamFam = new System.Windows.Forms.LinkLabel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lnkSiteWeb = new EsGace.Composantes.LinkEsGace(this.components);
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.tipPropos = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.tlpRemerciements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.tlpRemerciements, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lnkSiteWeb, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.okButton, 2, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // tlpRemerciements
            // 
            resources.ApplyResources(this.tlpRemerciements, "tlpRemerciements");
            this.tableLayoutPanel.SetColumnSpan(this.tlpRemerciements, 2);
            this.tlpRemerciements.Controls.Add(this.lnkTreeMap, 0, 2);
            this.tlpRemerciements.Controls.Add(this.lnkFamFamFam, 0, 1);
            this.tlpRemerciements.Controls.Add(this.textBoxDescription, 0, 0);
            this.tlpRemerciements.Name = "tlpRemerciements";
            // 
            // lnkTreeMap
            // 
            resources.ApplyResources(this.lnkTreeMap, "lnkTreeMap");
            this.lnkTreeMap.Name = "lnkTreeMap";
            this.lnkTreeMap.TabStop = true;
            this.lnkTreeMap.UseCompatibleTextRendering = true;
            this.lnkTreeMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTreeMap_LinkClicked);
            // 
            // lnkFamFamFam
            // 
            resources.ApplyResources(this.lnkFamFamFam, "lnkFamFamFam");
            this.lnkFamFamFam.Name = "lnkFamFamFam";
            this.lnkFamFamFam.TabStop = true;
            this.lnkFamFamFam.UseCompatibleTextRendering = true;
            this.lnkFamFamFam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFamFamFam_LinkClicked);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            // 
            // lnkSiteWeb
            // 
            resources.ApplyResources(this.lnkSiteWeb, "lnkSiteWeb");
            this.lnkSiteWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSiteWeb.Name = "lnkSiteWeb";
            this.lnkSiteWeb.TabStop = true;
            this.tipPropos.SetToolTip(this.lnkSiteWeb, resources.GetString("lnkSiteWeb.ToolTip"));
            this.lnkSiteWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSiteWeb_LinkClicked);
            // 
            // logoPictureBox
            // 
            resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
            this.logoPictureBox.Image = global::EsGace.Properties.Resources.About;
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelProductName, 2);
            resources.ApplyResources(this.labelProductName, "labelProductName");
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            // 
            // labelVersion
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 2);
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            // 
            // labelCopyright
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCopyright, 2);
            resources.ApplyResources(this.labelCopyright, "labelCopyright");
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            // 
            // labelCompanyName
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCompanyName, 2);
            resources.ApplyResources(this.labelCompanyName, "labelCompanyName");
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Name = "okButton";
            // 
            // APropos
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APropos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tlpRemerciements.ResumeLayout(false);
            this.tlpRemerciements.PerformLayout();
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
        private System.Windows.Forms.Button okButton;
        private EsGace.Composantes.LinkEsGace lnkSiteWeb;
        private System.Windows.Forms.ToolTip tipPropos;
        private System.Windows.Forms.TableLayoutPanel tlpRemerciements;
        private System.Windows.Forms.LinkLabel lnkFamFamFam;
        private System.Windows.Forms.LinkLabel lnkTreeMap;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}
