namespace App_LaRondeDesFacs
{
    partial class ConfigurationForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleRondeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerRésultatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterRésultatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerBorneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarerLaCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.configurerToolStripMenuItem,
            this.donnéesToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleRondeToolStripMenuItem,
            this.importerRésultatsToolStripMenuItem,
            this.exporterRésultatsToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouvelleRondeToolStripMenuItem
            // 
            this.nouvelleRondeToolStripMenuItem.Name = "nouvelleRondeToolStripMenuItem";
            this.nouvelleRondeToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.nouvelleRondeToolStripMenuItem.Text = "Synchroniser Utilisateurs";
            this.nouvelleRondeToolStripMenuItem.Click += new System.EventHandler(this.nouvelleRondeToolStripMenuItem_Click);
            // 
            // importerRésultatsToolStripMenuItem
            // 
            this.importerRésultatsToolStripMenuItem.Name = "importerRésultatsToolStripMenuItem";
            this.importerRésultatsToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.importerRésultatsToolStripMenuItem.Text = "Importer résultats";
            this.importerRésultatsToolStripMenuItem.Click += new System.EventHandler(this.importerRésultatsToolStripMenuItem_Click);
            // 
            // exporterRésultatsToolStripMenuItem
            // 
            this.exporterRésultatsToolStripMenuItem.Name = "exporterRésultatsToolStripMenuItem";
            this.exporterRésultatsToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.exporterRésultatsToolStripMenuItem.Text = "Exporter résultats";
            this.exporterRésultatsToolStripMenuItem.Click += new System.EventHandler(this.exporterRésultatsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // configurerToolStripMenuItem
            // 
            this.configurerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurerBorneToolStripMenuItem});
            this.configurerToolStripMenuItem.Name = "configurerToolStripMenuItem";
            this.configurerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.configurerToolStripMenuItem.Text = "Options";
            // 
            // configurerBorneToolStripMenuItem
            // 
            this.configurerBorneToolStripMenuItem.Name = "configurerBorneToolStripMenuItem";
            this.configurerBorneToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.configurerBorneToolStripMenuItem.Text = "Configurer borne";
            this.configurerBorneToolStripMenuItem.Click += new System.EventHandler(this.configurerBorneToolStripMenuItem_Click);
            // 
            // donnéesToolStripMenuItem
            // 
            this.donnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualiserToolStripMenuItem});
            this.donnéesToolStripMenuItem.Name = "donnéesToolStripMenuItem";
            this.donnéesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.donnéesToolStripMenuItem.Text = "Participants";
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            this.visualiserToolStripMenuItem.Click += new System.EventHandler(this.visualiserToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarerLaCourseToolStripMenuItem,
            this.résultatToolStripMenuItem});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // démarerLaCourseToolStripMenuItem
            // 
            this.démarerLaCourseToolStripMenuItem.Name = "démarerLaCourseToolStripMenuItem";
            this.démarerLaCourseToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.démarerLaCourseToolStripMenuItem.Text = "Démarrer la course";
            this.démarerLaCourseToolStripMenuItem.Click += new System.EventHandler(this.démarerLaCourseToolStripMenuItem_Click);
            // 
            // résultatToolStripMenuItem
            // 
            this.résultatToolStripMenuItem.Name = "résultatToolStripMenuItem";
            this.résultatToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.résultatToolStripMenuItem.Text = "Résultats";
            this.résultatToolStripMenuItem.Click += new System.EventHandler(this.résultatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Projet : La ronde des Facs - LP SIL IDSE 2014 2015";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1022, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleRondeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerRésultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterRésultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerBorneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarerLaCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}