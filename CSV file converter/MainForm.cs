using System.IO;
using System.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSV_file_converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Show the "source" tab when app is started
            mainTabControl.SelectedTab = tpSource;
        }


        /// <summary>
        /// Open source file. Attempt to load a CSV document and show it in the "source"
        /// text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseSourceFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Show the file name and path in the edit box:
                tbSourceFileName.Text = openFileDialog.FileName;

                // Load the text into a multi-line textbox:
                try
                {
                    tbSourceFile.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    tbSourceFile.Text = "Failed to load file." + Environment.NewLine + ex.Message;
                }

            }
        }


        private void btnGenerateSQL_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(tbSQLClause.Text)) || (string.IsNullOrWhiteSpace(tbSourceFile.Text)) || (string.IsNullOrWhiteSpace(tbSeparatorCharacter.Text)))
            {
                MessageBox.Show("Missing information. Source file, SQL clause and separator character are all missing");
                return;  // Nothing to do
            }

            int commitInterval = string.IsNullOrWhiteSpace(tbCommitLineCount.Text) ? 100 : Convert.ToInt32(tbCommitLineCount.Text);

            CSVtoSQLconvert converter = new CSVtoSQLconvert();
            List<string> results = converter.ConvertToSQL(
                tbSourceFile.Lines.ToList(),
                tbSQLClause.Text,
                cbHeaderRow.Checked,
                cbFieldsMustContainValue.Checked,
                tbSeparatorCharacter.Text,
                commitInterval);
            
            // Show the generated values
            tbResults.Text = string.Join(Environment.NewLine, results.ToArray());

            // Show the result tab:
            mainTabControl.SelectedTab = tpResults;

            btnSaveToFile.Focus();
        }

        /// <summary>
        /// Save the generated output to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, tbSourceFile.Text);
            }
        }
    }
}