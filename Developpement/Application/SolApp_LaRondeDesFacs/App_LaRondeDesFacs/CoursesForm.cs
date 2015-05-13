using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_LaRondeDesFacs
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        #region button

        #endregion

        #region menu
        private void résultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultatCourseForm resultatCourseForm = new ResultatCourseForm();
            resultatCourseForm.Show();
        }
        private void démarerLaCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.Show();
        }
        private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParticipantsForm participantsForm = new ParticipantsForm();
            participantsForm.Show();
        }
        private void configurerBorneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.Show();
        }
        private void nouvelleRondeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void importerRésultatsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void exporterRésultatsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AidesForm aidesForm = new AidesForm();
            aidesForm.Show();
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        private void CoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            lblErreur.Visible = false;

            // Vérifie si il existe bien cet utilisateur
            if (UserClass.getExistUser(txtUserIDmanuel.Text))
            {
                User user = UserClass.getUserID(txtUserIDmanuel.Text);
                Borne lastPassage = new Borne();
                DateTime lastPassageTime = new DateTime();
                int nbPassage = 0;

                // Vérifie si il y a déjà un tour qui a ete effectué par l'utilisateur
                if (BorneClass.getExistBorne(user.user_id))
                {
                    lastPassage = BorneClass.getLastNbPassageByUserID(user.user_id);

                    lastPassageTime = lastPassage.temps;
                    nbPassage = lastPassage.nb_passage;
                }

                // vérifie si le temps entre deux passages est en dessous de 10 secondes
                int dateCompare = (DateTime.Now.Second + DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600) - (lastPassageTime.Second + lastPassageTime.Minute * 60 + lastPassageTime.Hour * 3600);
                if (dateCompare > 10)
                {
                    Borne newPassage = new Borne();
                    newPassage.user_id = user.user_id;
                    newPassage.nb_passage = nbPassage + 1;
                    newPassage.temps = DateTime.Now;
                    BorneClass.setBorne(newPassage);

                    txtUserID.Text = user.user_id;
                    if (user.nom != null) txtNom.Text = user.nom;
                    if (user.prenom != null) txtPrenom.Text = user.prenom;
                    txtPassage.Text = newPassage.nb_passage.ToString();
                    txtHeure.Text = newPassage.temps.ToShortTimeString();
                }
                else
                {
                    lblErreur.Text = "Probleme : Double passage !";
                    lblErreur.Visible = true;
                }

                // Reinitialise le champ manuel
                txtUserIDmanuel.Text = "";
            }
            else
            {
                lblErreur.Text = "ID Utilisateur inconnu";
                lblErreur.Visible = true;
            }
        }

        private void btnDisqualification_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "")
            {
                string message = "Voulez vous vraiment disqualifier " + txtUserID.Text + "?";
                string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Borne borneDisqualifiant = new Borne();
                    borneDisqualifiant.user_id = txtUserID.Text;
                    borneDisqualifiant.temps = DateTime.Now;
                    borneDisqualifiant.nb_passage = -1;
                    BorneClass.setBorne(borneDisqualifiant);
                    lblErreur.Text = "L'utilisateur " + txtUserID.Text + " est disqualifié.";
                    lblErreur.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Aucun utilisateur est sélectionné.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUserID.Text != "")
            {
                string message = "Voulez vous vraiment signaler l'utilisateur " + txtUserID.Text + "?";
                string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Borne borneDisqualifiant = new Borne();
                    borneDisqualifiant.user_id = txtUserID.Text;
                    borneDisqualifiant.temps = DateTime.Now;
                    borneDisqualifiant.nb_passage = -2;
                    BorneClass.setBorne(borneDisqualifiant);
                    lblErreur.Text = "L'utilisateur " + txtUserID.Text + " est signalé.";
                    lblErreur.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Aucun utilisateur est sélectionné.");
            }
        }
    }
}
