using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace App_LaRondeDesFacs
{
    public partial class SynchroniserForm : Form
    {
        public SynchroniserForm()
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

        private void btnSynUti_Click(object sender, EventArgs e)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            // ... Target page.
            string page = "http://en.wikipedia.org/";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                // ... Display the result.
                if (result != null)
                {
                    MessageBox.Show(result);
                }
                else MessageBox.Show("probleme");
            }


            //using (var client = new HttpClient())
            //{
            //    //client.BaseAddress = new Uri("http://localhost/larondedesfacs/Projet-RFID---La-Ronde-des-Facs/Developpement/website/API/getUsers.php");
            //    client.BaseAddress = new Uri("http://localhost/larondedesfacs/Projet-RFID---La-Ronde-des-Facs/Developpement/website/");

            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    HttpResponseMessage response = await client.GetAsync("API/getUserById.php?userId=pv123456");
            //    if (response.IsSuccessStatusCode)
            //    {
            //        String test = await response.Content.ReadAsStringAsync();
            //        MessageBox.Show(test);
            //        //Console.WriteLine("{0}\t${1}\t{2}\t{3}\t{4}\t{5}", user.user_id, user.nom, user.prenom, user.date_naissance, user.faculte, user.promotion);
            //    }
            //}
        }

    }
}
