using System;
using System.IO;
using System.Windows.Forms;

namespace Funzione_gui
{
    public partial class Form1 : Form
    {
        private int pos = 0;
        private string stuff = "Made with <3 by @Fede.Tensi.";

        public Form1()
        {

            InitializeComponent();
            /*timer1.Enabled = true;
            timer1.Interval = 1000;*/

            ldata.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
            ltime.Text = "Orario: " + DateTime.Now.ToString("HH:mm:ss");
            lcred.Text = "";
            Text = "Percentuale Alunni :: Home [" + DateTime.Now.ToString("HH:mm:ss") + "]";
            Update();
        }




        
        private void timer1_Tick(object sender, EventArgs e)
        {

            ltime.Text = "Orario: " + DateTime.Now.ToString("HH:mm:ss");
            Text = "Percentuale Alunni :: Home [" + DateTime.Now.ToString("HH:mm:ss") + "]";
            Update();

            if (pos < stuff.Length)
            { lcred.Text += stuff.Substring(pos, 1);  ++pos; }
            else { lcred.Text = ""; pos = 0; }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the ProgressBar control.
            pBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            pBar1.Minimum = 1;

            // Set the initial value of the ProgressBar.
            pBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pBar1.Step = 1;

            cbType.Text = "EXCEL";

        }

        public void clear()
        {
            tbClassName.Text = "";
            tbF.Value = 0;
            tbM.Value = 0;
        }

        private void binsert_Click(object sender, EventArgs e)
        {
            int tot = 0, num_m = 0, num_f = 0, pf = 0, pm = 0;

            if (tbClassName.Text.Length != 0)
            {
                if (tbF.Value == 0 && tbM.Value == 0)
                {
                    MessageBox.Show("Entrambi i numeri di maschi e femmine non possono essere zero!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    num_f = Convert.ToInt32(tbF.Value);
                    num_m = Convert.ToInt32(tbM.Value);


                    tot = num_m + num_f;
                    pf = (int)Math.Round((double)(100 * num_f) / tot);
                    pm = (int)Math.Round((double)(100 * num_m) / tot);

                    //classe perm perf tot
                    dataGridView1.Rows.Add(tbClassName.Text, pm + "%", pf + "%", tot);
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Inserire il nome della classe!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void bexp_Click(object sender, EventArgs e)
        {
            pBar1.Maximum = dataGridView1.Rows.Count;

            switch (cbType.Text)
            {
                case "EXCEL":
                    exportEXCEL();
                    break;

                case "TXT":
                    exportTXT();
                    break;

                default:
                    exportEXCEL();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void boption_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm();
            optionForm.Show();
        }

        #region Export Type

        public void errorBox(System.Exception exception)
        {
            MessageBox.Show("Errore inaspettato: \n\n" + exception, ":: ERRORE FATALE ::", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
        }

        public void exportEXCEL()
        {

            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (int x = 1; x < dataGridView1.Columns.Count + 1; x++)
                {
                    xlWorkSheet.Cells[1, x] = dataGridView1.Columns[x - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        pBar1.PerformStep();
                    }
                }

                SaveFileDialog saveFileDialoge = new SaveFileDialog
                {
                    Filter = "XML Files (*.xml; *.xls; *.xlsx) |*.xml; *.xls; *.xlsx",//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                    FilterIndex = 3,

                    Title = "Percentuale Alunni :: Esportare",   //define the name of openfileDialog
                    InitialDirectory = @"Desktop", //define the initial directory

                    FileName = "Percentuale alunni " + DateTime.Now.ToString("dd-MM-yyyy"),
                    DefaultExt = ".xlsx"
                };

                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    xlWorkBook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    MessageBox.Show("Dati esportati!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                pBar1.Value = 1;
            }
            catch (Exception ex)
            {
                errorBox(ex);
            }
        }

        public void exportTXT()
        {
            try
            {
                DialogResult result = MessageBox.Show("Questo formato non permette la successiva importazione!", "AVVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    SaveFileDialog saveFileDialoge = new SaveFileDialog
                    {
                        Filter = "TXT Files (*.txt) |*.txt",//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                        FilterIndex = 3,

                        Title = "Percentuale Alunni :: Esportare",   //define the name of openfileDialog
                        InitialDirectory = @"Desktop", //define the initial directory

                        FileName = "Percentuale alunni " + DateTime.Now.ToString("dd-MM-yyyy"),
                        DefaultExt = ".txt"
                    };

                    if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                    {
                        string selected_path = saveFileDialoge.FileName;

                        TextWriter writer = new StreamWriter(selected_path);
                        writer.WriteLine("Registrati in data: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        writer.WriteLine("---------------------------------");
                        writer.WriteLine(" CLASSE | Maschi | Femmine | TOTALE |");
                        writer.WriteLine("---------------------------------");
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                pBar1.PerformStep();
                            }
                            writer.WriteLine("");
                            writer.WriteLine("---------------------------------");
                        }
                        writer.WriteLine(" ");
                        writer.WriteLine("     Made with <3 by Fede.Tensi     ");
                        writer.WriteLine(" ");
                        writer.WriteLine("---------------------------------");
                        writer.Close();
                        MessageBox.Show("Dati esportati!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pBar1.Value = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Non verrà esportato nessun dato!", "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {

                errorBox(ex);
            }
        }

        #endregion

        private void bdelete_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void bimport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Cancellare i dati gia presenti?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                }

            }

            try
            {
                string fileName;
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb",//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                    FilterIndex = 3,

                    Multiselect = false,        //not allow multiline selection at the file selection level
                    Title = "Percentuale Alunni :: Importare",   //define the name of openfileDialog
                    InitialDirectory = @"Desktop" //define the initial directory
                };  //create openfileDialog Object

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Open(pathName);
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;

                    int rcount = worksheet.UsedRange.Rows.Count;

                    int i = 1;

                    for (; i < rcount; i++)
                    {
                        dataGridView1.Rows.Add(
                            worksheet.Cells[i + 1, 1].Value,
                            worksheet.Cells[i + 1, 2].Value.ToString("0.##%"),
                            worksheet.Cells[i + 1, 3].Value.ToString("0.##%"),
                            worksheet.Cells[i + 1, 4].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                errorBox(ex);
            }
        }

        
    }
}

