namespace App_LaRondeDesFacs
{
    partial class CoursesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTour = new System.Windows.Forms.Button();
            this.txtUserIDmanuel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnDisqualification = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTour);
            this.groupBox1.Controls.Add(this.txtUserIDmanuel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 597);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passage manuel";
            // 
            // btnTour
            // 
            this.btnTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.Location = new System.Drawing.Point(600, 21);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(143, 103);
            this.btnTour.TabIndex = 10;
            this.btnTour.Text = "TOUR";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // txtUserIDmanuel
            // 
            this.txtUserIDmanuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDmanuel.Location = new System.Drawing.Point(306, 46);
            this.txtUserIDmanuel.Name = "txtUserIDmanuel";
            this.txtUserIDmanuel.Size = new System.Drawing.Size(266, 53);
            this.txtUserIDmanuel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Utilisateur";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(267, 70);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(467, 143);
            this.txtUserID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(48, 302);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(266, 53);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(48, 401);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(266, 53);
            this.txtPrenom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom";
            // 
            // txtHeure
            // 
            this.txtHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeure.Location = new System.Drawing.Point(694, 326);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.ReadOnly = true;
            this.txtHeure.Size = new System.Drawing.Size(305, 98);
            this.txtHeure.TabIndex = 9;
            this.txtHeure.Text = "-- : -- : --";
            this.txtHeure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(817, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Heure";
            // 
            // txtPassage
            // 
            this.txtPassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassage.Location = new System.Drawing.Point(361, 326);
            this.txtPassage.Name = "txtPassage";
            this.txtPassage.ReadOnly = true;
            this.txtPassage.Size = new System.Drawing.Size(305, 98);
            this.txtPassage.TabIndex = 11;
            this.txtPassage.Text = "--";
            this.txtPassage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre de passage";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(12, 543);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(230, 32);
            this.lblErreur.TabIndex = 12;
            this.lblErreur.Text = "erreur détecté ?";
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErreur.Visible = false;
            // 
            // btnDisqualification
            // 
            this.btnDisqualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisqualification.Location = new System.Drawing.Point(821, 495);
            this.btnDisqualification.Name = "btnDisqualification";
            this.btnDisqualification.Size = new System.Drawing.Size(189, 60);
            this.btnDisqualification.TabIndex = 13;
            this.btnDisqualification.Text = "Disqualification";
            this.btnDisqualification.UseVisualStyleBackColor = true;
            this.btnDisqualification.Click += new System.EventHandler(this.btnDisqualification_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(689, 569);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(320, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "L\'utilisateur rencontre un problème ? Signalez le !";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1022, 753);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDisqualification);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.txtPassage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CoursesForm";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.TextBox txtUserIDmanuel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnDisqualification;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}