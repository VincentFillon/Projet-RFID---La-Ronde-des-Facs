namespace App_LaRondeDesFacs
{
    partial class ParticipantsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbListeDesParticipants = new System.Windows.Forms.GroupBox();
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser_ID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbListeDesParticipants.SuspendLayout();
            this.gbRecherche.SuspendLayout();
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
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 368);
            this.dataGridView1.TabIndex = 2;
            // 
            // gbListeDesParticipants
            // 
            this.gbListeDesParticipants.Controls.Add(this.dataGridView1);
            this.gbListeDesParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListeDesParticipants.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbListeDesParticipants.Location = new System.Drawing.Point(12, 214);
            this.gbListeDesParticipants.Name = "gbListeDesParticipants";
            this.gbListeDesParticipants.Size = new System.Drawing.Size(998, 416);
            this.gbListeDesParticipants.TabIndex = 3;
            this.gbListeDesParticipants.TabStop = false;
            this.gbListeDesParticipants.Text = "Liste des participants";
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(this.txtNom);
            this.gbRecherche.Controls.Add(this.label2);
            this.gbRecherche.Controls.Add(this.btnSearch);
            this.gbRecherche.Controls.Add(this.txtUser_ID);
            this.gbRecherche.Controls.Add(this.label1);
            this.gbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherche.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbRecherche.Location = new System.Drawing.Point(12, 33);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(998, 175);
            this.gbRecherche.TabIndex = 4;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Recherche";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(12, 636);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commandes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de l\'utilisateur";
            // 
            // txtUser_ID
            // 
            this.txtUser_ID.Location = new System.Drawing.Point(288, 60);
            this.txtUser_ID.Name = "txtUser_ID";
            this.txtUser_ID.Size = new System.Drawing.Size(100, 27);
            this.txtUser_ID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(960, 49);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(729, 60);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 27);
            this.txtNom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Non de l\'utilisateur";
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1022, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbListeDesParticipants);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ParticipantsForm";
            this.Text = "Participants";
            this.Load += new System.EventHandler(this.ParticipantsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbListeDesParticipants.ResumeLayout(false);
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleRondeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerRésultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterRésultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerBorneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarerLaCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbListeDesParticipants;
        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUser_ID;
        private System.Windows.Forms.Label label1;
    }
}