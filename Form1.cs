using System;
using System.Data;
using System.Drawing.Printing;

namespace PRT_ETQ_QR_CODE {

    public partial class Form1 : Form {

        int linesInDataFile = 0;
        string textToPrint = "";
        string[] textToReplace;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Form1_Shown(object sender, EventArgs e) {
            SelectPrinters();
        }

        private void btnFile_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text File|*.txt";

            ofd.Multiselect = false;

            ofd.ShowDialog();

            if (ofd.FileName == "") return;

            tbFile.Text = ofd.FileName;
            textToPrint = File.ReadAllText(ofd.FileName);
            

        }

        private void btnData_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Comma Separated Value|*.csv";

            ofd.Multiselect = false;

            ofd.ShowDialog();

            if (ofd.FileName == "") return;

            tbDTFile.Text = ofd.FileName;

            ReadDataFile();

        }

        private void btnPrint_Click(object sender, EventArgs e) {
            PrintFiles();
        }

        void ReadDataFile() {

            dgvText.Rows.Clear();

            if (tbDTFile.Text == "")
                return;

            using(StreamReader rd = new StreamReader(tbDTFile.Text)) {

                string firstLine = rd.ReadLine();

                if (firstLine != "") {

                    string[] content = firstLine.Split(',');
                    int index = 0;

                    foreach(string s in content) {

                        dgvText.Rows.Add(index.ToString(), s, "<<REPLACE>>");

                        index++;

                    }

                }

                linesInDataFile = File.ReadLines(tbDTFile.Text).Count();
                textToReplace = File.ReadAllLines(tbDTFile.Text);

                pbPrint.Maximum = linesInDataFile;

                tbLineTot.Text = linesInDataFile.ToString();

            }

        }

        void SelectPrinters() {
            foreach (string printer in PrinterSettings.InstalledPrinters) {
                cbPrinters.Items.Add(printer);
            }
        }

        void PrintFiles() {

            bool isFirstLine = true;
            
            // TextToReplace contém cada linha do CSV para arrumar
            foreach (string line in textToReplace) {

                pbPrint.PerformStep();

                if (cbFirstLine.Checked && isFirstLine) {
                    isFirstLine = false;
                    continue;
                }

                bool hasEmpty = false;

                string currentFile = textToPrint;
                string[] arr = line.Split(',');

                foreach (DataGridViewRow row in dgvText.Rows) {
                    string txtToReplace = row.Cells["TextRPL"].Value.ToString();
                    string repWith = arr[Convert.ToInt32(row.Cells["RowID"].Value.ToString())].ToString();

                    if (txtToReplace == "" || repWith == "")
                        hasEmpty = true;

                    currentFile = currentFile.Replace(txtToReplace, repWith);
                }

                if (cbIgnoreEmpty.Checked && hasEmpty)
                    continue;

                PrintDocument p = new PrintDocument();
                p.PrinterSettings.PrinterName = cbPrinters.SelectedItem.ToString();

                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(currentFile, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                };
                try {
                    p.Print();
                } catch (Exception ex) {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }

            MessageBox.Show("All files were printed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pbPrint.Value = 0;
        }
    }
}