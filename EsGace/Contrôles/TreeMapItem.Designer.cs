namespace EsGace.Contrôles
{
    partial class TreeMapItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tmcCtl = new Microsoft.Research.CommunityTechnologies.Treemap.TreemapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tmcCtl
            // 
            this.tmcCtl.AllowDrag = false;
            this.tmcCtl.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.tmcCtl.DiscreteNegativeColors = 50;
            this.tmcCtl.DiscretePositiveColors = 50;
            this.tmcCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tmcCtl.EmptySpaceLocation = Microsoft.Research.CommunityTechnologies.Treemap.EmptySpaceLocation.DeterminedByLayoutAlgorithm;
            this.tmcCtl.FontFamily = "Arial";
            this.tmcCtl.FontSolidColor = System.Drawing.SystemColors.WindowText;
            this.tmcCtl.IsZoomable = true;
            this.tmcCtl.LayoutAlgorithm = Microsoft.Research.CommunityTechnologies.Treemap.LayoutAlgorithm.TopWeightedSquarified;
            this.tmcCtl.Location = new System.Drawing.Point(0, 31);
            this.tmcCtl.MaxColor = System.Drawing.Color.Green;
            this.tmcCtl.MaxColorMetric = 100F;
            this.tmcCtl.MinColor = System.Drawing.Color.Red;
            this.tmcCtl.MinColorMetric = -1F;
            this.tmcCtl.Name = "tmcCtl";
            this.tmcCtl.NodeColorAlgorithm = Microsoft.Research.CommunityTechnologies.Treemap.NodeColorAlgorithm.UseColorMetric;
            this.tmcCtl.NodeLevelsWithText = Microsoft.Research.CommunityTechnologies.Treemap.NodeLevelsWithText.All;
            this.tmcCtl.PaddingDecrementPerLevelPx = 1;
            this.tmcCtl.PaddingPx = 5;
            this.tmcCtl.PenWidthDecrementPerLevelPx = 1;
            this.tmcCtl.PenWidthPx = 3;
            this.tmcCtl.SelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.tmcCtl.SelectedFontColor = System.Drawing.SystemColors.HighlightText;
            this.tmcCtl.ShowToolTips = true;
            this.tmcCtl.Size = new System.Drawing.Size(427, 365);
            this.tmcCtl.TabIndex = 0;
            this.tmcCtl.TextLocation = Microsoft.Research.CommunityTechnologies.Treemap.TextLocation.CenterCenter;
            this.tmcCtl.NodeDoubleClick += new Microsoft.Research.CommunityTechnologies.Treemap.TreemapControl.NodeEventHandler(this.tmcCtl_NodeDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 31);
            this.panel1.TabIndex = 1;
            // 
            // TreeMapItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tmcCtl);
            this.Controls.Add(this.panel1);
            this.Name = "TreeMapItem";
            this.Size = new System.Drawing.Size(427, 396);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Research.CommunityTechnologies.Treemap.TreemapControl tmcCtl;
        private System.Windows.Forms.Panel panel1;
    }
}
