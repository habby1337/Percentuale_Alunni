using System;
using System.IO;
using System.Windows.Forms;

namespace Funzione_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        public void startExport()
        {
            switch (cbType.Text)
            {
                case "EXCEL":
                    exportEXCEL();
                    break;

                case "TXT":
                    exportTXT();
                    break;

                default:
                    break;
            }
        }

        private void bexp_Click(object sender, EventArgs e)
        {
            startExport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void boption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ASS SOOOOOON AS POSSIBLE!!");
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
                    }
                }

                SaveFileDialog saveFileDialoge = new SaveFileDialog
                {
                    FileName = "Percentuale alunni " + DateTime.Now.ToString("dd-MM-yyyy"),
                    DefaultExt = ".xlsx"
                };
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    xlWorkBook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }


                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                MessageBox.Show("Dati esportati!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
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
                SaveFileDialog saveFileDialoge = new SaveFileDialog
                {
                    FileName = "Percentuale alunni " + DateTime.Now.ToString("dd-MM-yyyy"),
                    DefaultExt = ".txt"
                };
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {

                    string selected_path = saveFileDialoge.FileName;

                 
                    writer.WriteLine("Registrati in data: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    writer.WriteLine("---------------------------------");
                    writer.WriteLine(" CLASSE | Maschi | Femmine | TOTALE |");
                    writer.WriteLine("---------------------------------");
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
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

                }
            }
            catch (Exception ex)
            {

                errorBox(ex);
            }
        }


        #endregion

    }
}
