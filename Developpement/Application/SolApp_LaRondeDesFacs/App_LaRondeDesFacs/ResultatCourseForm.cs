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
    public partial class ResultatCourseForm : Form
    {
        public radioB radio;
 
        public ResultatCourseForm()
        {
            InitializeComponent();
        }

        private void ResultatCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BorneClass.getAllListBorne();
            radio = radioB.TousLesPassages;
        }

        #region button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUser_ID.Text != "")
            {
                if (txtUser_ID.Text != "")
                {
                    switch (radio) {
                        case radioB.TousLesPassages :
                            DataGridViewPassages(true);
                            break;
                        case radioB.NombreT :
                            DataGridViewNombreT(true);
                            break;
                        case radioB.Disqualifie :
                            DataGridViewDisqualifie(true);
                            break;
                        case radioB.Avertissement :
                            DataGridViewAvertissement(true);
                            break;
                        default :
                            DataGridViewPassages(false);
                            break;
                    }
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                DataGridViewPassages(false);
            }
        }
        private void rbNombreT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombreT.Checked)
            {
                radio = radioB.NombreT;
                DataGridViewNombreT(false);
            }
        }

        private void rbMeilleurT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMeilleurT.Checked)
                radio = radioB.MeilleurT;
        }

        private void rbDisq_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDisq.Checked)
            {
                radio = radioB.Disqualifie;
                DataGridViewDisqualifie(false);
            }
        }

        private void rbAvert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAvert.Checked)
            {
                radio = radioB.Avertissement;
                DataGridViewAvertissement(false);
            }
        }

        private void rbPassages_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPassages.Checked)
            {
                radio = radioB.TousLesPassages;
                DataGridViewPassages(false);
            }
        }
        #endregion

        #region methodes
        public void DataGridViewNombreT(bool isUser)
        {
            if (isUser)
            {
                dataGridView1.DataSource = BorneClass.getLastNbPassageByUserID(txtUser_ID.Text);
            }
            else
            {
                dataGridView1.DataSource = BorneClass.getNombreTourAllListBorne();
            }
        }
        public void DataGridViewMeilleurT(bool isUser)
        {
            if (isUser)
            {
                dataGridView1.DataSource = BorneClass.getLastNbPassageByUserID(txtUser_ID.Text);
            }
            else
            {
                dataGridView1.DataSource = BorneClass.getNombreTourAllListBorne();
            }
        }
        public void DataGridViewDisqualifie(bool isUser)
        {
            if (isUser)
            {
                dataGridView1.DataSource = BorneClass.getProblemBorneByUserID(txtUser_ID.Text);
            }
            else
            {
                dataGridView1.DataSource = BorneClass.getProblemAllListBorne();
            }
        }
        public void DataGridViewAvertissement(bool isUser)
        {
            if (isUser)
            {
                dataGridView1.DataSource = BorneClass.getAvertissementBorneByUserID(txtUser_ID.Text); // a modifier
            }
            else
            {
                dataGridView1.DataSource = BorneClass.getAvertissementAllListBorne();
            }
        }
        public void DataGridViewPassages(bool isUser)
        {
            if (isUser)
            {
                dataGridView1.DataSource = BorneClass.getBorneByUserID(txtUser_ID.Text); // a modifier
            }
            else
            {
                dataGridView1.DataSource = BorneClass.getAllListBorne();
            }
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

    public enum radioB
    {
        MeilleurT,
        NombreT,
        Disqualifie,
        Avertissement,
        TousLesPassages
    }
}
