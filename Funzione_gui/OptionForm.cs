using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using ApplicationForm = System.Windows.Forms.Application;

namespace Funzione_gui
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            lver.Text = "Versione: " + ApplicationForm.ProductVersion;
            TBLog.Visible = false;
        }

        private void lver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versione software: " + ApplicationForm.ProductVersion, "INFO [" + ApplicationForm.ProductVersion + "]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string log(string log)
        {
            return TBLog.Text += DateTime.Now.ToString("HH:mm:ss") + ": " + log + "\n";
        }

        public void errorBox(System.Exception exception)
        {
            MessageBox.Show("Errore inaspettato: \n\n" + exception, ":: ERRORE FATALE ::", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
        }


        private void bupdate_Click(object sender, EventArgs e)
        {
            TBLog.Visible = true;
            getUpdate();
        }

        private async Task<string> GetReleaseVersionAsync()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("PA"));
            IReadOnlyList<Release> tmp = await client.Repository.Release.GetAll("habby1337", "Percentuale_Alunni");

            Release latest = tmp[0];
            string version = latest.TagName;

            return Convert.ToString(version);
        }

        private async void getUpdate()
        {
            try
            {
                log("Creando la richiesta web");
                using (WebClient client = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    log("Richiesta web creata!");


                    log("Cercando aggiornamenti da github...");

                    string versione_string = await GetReleaseVersionAsync();

                    if (Convert.ToDecimal(versione_string) > Convert.ToDecimal(ApplicationForm.ProductVersion))
                    {
                        DialogResult result = MessageBox.Show("è stato trovato un aggiornamento...\n Vuoi scaricarlo?", "Aggiornamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        log("Aggiornamento trovato!");

                        if (result == DialogResult.Yes)
                        {
                        //AGGIORNARE IL DOWNLOAD
                            //https://github.com/habby1337/Percentuale_Alunni/releases/download/1.0.0.1/PercentualeAlunni.exe
                           // Uri uri = new Uri("https://github.com/habby1337/Percentuale_Alunni/releases/download/" + GetReleaseVersionAsync() + "/PercentualeAlunni.exe"); //
                            //client.DownloadFileAsync(uri, "PercentualeAlunni_new.exe");



                            var uri = new Uri("https://github.com/habby1337/Percentuale_Alunni/releases/download/" + versione_string + "/PercentualeAlunni.exe"); //

                            client.DownloadFileAsync(uri, "PercentualeAlunni_new.exe");




                            log("Scaricando l'aggionamento...[0%]");
                            log("Scaricando l'aggionamento...[50%]");
                            log("Scaricando gli asset...[0%]");
                            log("Scaricando gli asset...[100%]"); ;
                            log("Completando la richiesta...[0%]");
                            log("Completando la richiesta...[100%]");
                            log("Aggiornamento scaricato!...[100%]");

                            client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completato);
                            
                        }
                        else
                        {
                            log("Aggiornamento annullato!");
                            MessageBox.Show("Non verrà eseguito l'aggiornamento", "Aggiornamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (Convert.ToDecimal(versione_string) <= Convert.ToDecimal(ApplicationForm.ProductVersion))
                    {
                        log("Aggiornamento non trovato!");
                        MessageBox.Show("Nessun aggiornamento trovato", "Aggiornamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex )
            {
                errorBox(ex);
            }
        }

        public void Completato(object o, AsyncCompletedEventArgs args)
        {
            log("Disinstallando la vecchia versione...[0%]");
            log("Disinstallata la vecchia verisone[40%]");

            MessageBox.Show("Disintallando la vecchia versione", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string app_name = ApplicationForm.StartupPath + "\\" + ApplicationForm.ProductName + ".exe";
            string bat_name = app_name + ".bat";

            string bat = 
                "@echo off\n"                                                                                          //CHECK BEFORE RELEASE
                + ":loop\n"
                + "del \"" + app_name + "\"\n"
                + "if Exist \"" + app_name + "\" GOTO loop\n"
                + "ren PercentualeAlunni_new.exe PercentualeAlunni.exe\n"
                + "del %0\n"
                + "start PercentualeAlunni.exe";

            StreamWriter file = new StreamWriter(bat_name);
            file.Write(bat);
            file.Close();

            Process bat_call = new Process();
            bat_call.StartInfo.FileName = bat_name;
            bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            bat_call.StartInfo.UseShellExecute = true;
            bat_call.Start();

            log("Disinstallata la vecchia verisone[100%]");
            log("Download terminato.");

            ApplicationForm.Exit();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
