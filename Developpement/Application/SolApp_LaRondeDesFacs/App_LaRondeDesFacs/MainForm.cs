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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region button
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm participantsForm = new ParticipantsForm();
            participantsForm.Show();
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.Show();
        }
        private void btnSynchroniser_Click(object sender, EventArgs e)
        {
            SynchroniserForm synchorniserForm = new SynchroniserForm();
            synchorniserForm.Show();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.Show();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
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
    }
}
