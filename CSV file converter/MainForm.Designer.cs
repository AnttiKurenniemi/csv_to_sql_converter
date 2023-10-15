namespace CSV_file_converter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowseSourceFile = new Button();
            tbSourceFileName = new TextBox();
            openFileDialog = new OpenFileDialog();
            tbSourceFile = new TextBox();
            cbHeaderRow = new CheckBox();
            tbSQLClause = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSeparatorCharacter = new TextBox();
            btnGenerateSQL = new Button();
            cbFieldsMustContainValue = new CheckBox();
            btnSaveToFile = new Button();
            saveFileDialog = new SaveFileDialog();
            label3 = new Label();
            tbCommitLineCount = new TextBox();
            mainTabControl = new TabControl();
            tpSource = new TabPage();
            tpResults = new TabPage();
            tbResults = new TextBox();
            label4 = new Label();
            mainTabControl.SuspendLayout();
            tpSource.SuspendLayout();
            tpResults.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowseSourceFile
            // 
            btnBrowseSourceFile.Location = new Point(664, 29);
            btnBrowseSourceFile.Margin = new Padding(2);
            btnBrowseSourceFile.Name = "btnBrowseSourceFile";
            btnBrowseSourceFile.Size = new Size(42, 35);
            btnBrowseSourceFile.TabIndex = 0;
            btnBrowseSourceFile.Text = "...";
            btnBrowseSourceFile.UseVisualStyleBackColor = true;
            btnBrowseSourceFile.Click += btnBrowseSourceFile_Click;
            // 
            // tbSourceFileName
            // 
            tbSourceFileName.Location = new Point(7, 31);
            tbSourceFileName.Margin = new Padding(2);
            tbSourceFileName.Name = "tbSourceFileName";
            tbSourceFileName.Size = new Size(653, 31);
            tbSourceFileName.TabIndex = 1;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // tbSourceFile
            // 
            tbSourceFile.Dock = DockStyle.Fill;
            tbSourceFile.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSourceFile.Location = new Point(3, 3);
            tbSourceFile.Margin = new Padding(2);
            tbSourceFile.Multiline = true;
            tbSourceFile.Name = "tbSourceFile";
            tbSourceFile.ScrollBars = ScrollBars.Vertical;
            tbSourceFile.Size = new Size(1485, 420);
            tbSourceFile.TabIndex = 2;
            tbSourceFile.WordWrap = false;
            // 
            // cbHeaderRow
            // 
            cbHeaderRow.AutoSize = true;
            cbHeaderRow.Checked = true;
            cbHeaderRow.CheckState = CheckState.Checked;
            cbHeaderRow.Location = new Point(12, 81);
            cbHeaderRow.Margin = new Padding(2);
            cbHeaderRow.Name = "cbHeaderRow";
            cbHeaderRow.Size = new Size(204, 29);
            cbHeaderRow.TabIndex = 3;
            cbHeaderRow.Text = "File has a header row";
            cbHeaderRow.UseVisualStyleBackColor = true;
            // 
            // tbSQLClause
            // 
            tbSQLClause.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSQLClause.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSQLClause.Location = new Point(7, 195);
            tbSQLClause.Margin = new Padding(2);
            tbSQLClause.Multiline = true;
            tbSQLClause.Name = "tbSQLClause";
            tbSQLClause.ScrollBars = ScrollBars.Vertical;
            tbSQLClause.Size = new Size(1499, 73);
            tbSQLClause.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 168);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(635, 25);
            label1.TabIndex = 5;
            label1.Text = "SQL clause. Use {0} for first field, {1} for second field and so on (max 100 fields)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 7;
            label2.Text = "Separator character";
            // 
            // tbSeparatorCharacter
            // 
            tbSeparatorCharacter.Location = new Point(179, 113);
            tbSeparatorCharacter.Margin = new Padding(2);
            tbSeparatorCharacter.Name = "tbSeparatorCharacter";
            tbSeparatorCharacter.ScrollBars = ScrollBars.Vertical;
            tbSeparatorCharacter.Size = new Size(58, 31);
            tbSeparatorCharacter.TabIndex = 6;
            tbSeparatorCharacter.Text = ";";
            // 
            // btnGenerateSQL
            // 
            btnGenerateSQL.Location = new Point(7, 272);
            btnGenerateSQL.Margin = new Padding(2);
            btnGenerateSQL.Name = "btnGenerateSQL";
            btnGenerateSQL.Size = new Size(144, 41);
            btnGenerateSQL.TabIndex = 8;
            btnGenerateSQL.Text = "Generate SQL";
            btnGenerateSQL.UseVisualStyleBackColor = true;
            btnGenerateSQL.Click += btnGenerateSQL_Click;
            // 
            // cbFieldsMustContainValue
            // 
            cbFieldsMustContainValue.AutoSize = true;
            cbFieldsMustContainValue.Checked = true;
            cbFieldsMustContainValue.CheckState = CheckState.Checked;
            cbFieldsMustContainValue.Location = new Point(371, 81);
            cbFieldsMustContainValue.Margin = new Padding(2);
            cbFieldsMustContainValue.Name = "cbFieldsMustContainValue";
            cbFieldsMustContainValue.Size = new Size(269, 29);
            cbFieldsMustContainValue.TabIndex = 9;
            cbFieldsMustContainValue.Text = "All fields must be non-empty";
            cbFieldsMustContainValue.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveToFile.Location = new Point(1370, 278);
            btnSaveToFile.Margin = new Padding(2);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(132, 35);
            btnSaveToFile.TabIndex = 10;
            btnSaveToFile.Text = "Save to file";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "sql";
            saveFileDialog.Filter = "SQL files|*.sql|All files|*.*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 25);
            label3.TabIndex = 12;
            label3.Text = "Commit (go) every x lines";
            // 
            // tbCommitLineCount
            // 
            tbCommitLineCount.Location = new Point(594, 115);
            tbCommitLineCount.Margin = new Padding(2);
            tbCommitLineCount.Name = "tbCommitLineCount";
            tbCommitLineCount.ScrollBars = ScrollBars.Vertical;
            tbCommitLineCount.Size = new Size(58, 31);
            tbCommitLineCount.TabIndex = 11;
            tbCommitLineCount.Text = "100";
            // 
            // mainTabControl
            // 
            mainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabControl.Controls.Add(tpSource);
            mainTabControl.Controls.Add(tpResults);
            mainTabControl.Location = new Point(7, 318);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1499, 464);
            mainTabControl.TabIndex = 13;
            // 
            // tpSource
            // 
            tpSource.Controls.Add(tbSourceFile);
            tpSource.Location = new Point(4, 34);
            tpSource.Name = "tpSource";
            tpSource.Padding = new Padding(3);
            tpSource.Size = new Size(1491, 426);
            tpSource.TabIndex = 0;
            tpSource.Text = "Source file";
            tpSource.UseVisualStyleBackColor = true;
            // 
            // tpResults
            // 
            tpResults.Controls.Add(tbResults);
            tpResults.Location = new Point(4, 34);
            tpResults.Name = "tpResults";
            tpResults.Padding = new Padding(3);
            tpResults.Size = new Size(1491, 426);
            tpResults.TabIndex = 1;
            tpResults.Text = "Resulting SQL";
            tpResults.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            tbResults.Dock = DockStyle.Fill;
            tbResults.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbResults.Location = new Point(3, 3);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ScrollBars = ScrollBars.Vertical;
            tbResults.Size = new Size(1485, 420);
            tbResults.TabIndex = 0;
            tbResults.WordWrap = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 5);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 14;
            label4.Text = "Source file";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 788);
            Controls.Add(label4);
            Controls.Add(mainTabControl);
            Controls.Add(label3);
            Controls.Add(tbCommitLineCount);
            Controls.Add(btnSaveToFile);
            Controls.Add(cbFieldsMustContainValue);
            Controls.Add(btnGenerateSQL);
            Controls.Add(label2);
            Controls.Add(tbSeparatorCharacter);
            Controls.Add(label1);
            Controls.Add(tbSQLClause);
            Controls.Add(cbHeaderRow);
            Controls.Add(tbSourceFileName);
            Controls.Add(btnBrowseSourceFile);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "CSV to SQL converter";
            Load += MainForm_Load;
            mainTabControl.ResumeLayout(false);
            tpSource.ResumeLayout(false);
            tpSource.PerformLayout();
            tpResults.ResumeLayout(false);
            tpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseSourceFile;
        private TextBox tbSourceFileName;
        private OpenFileDialog openFileDialog;
        private TextBox tbSourceFile;
        private CheckBox cbHeaderRow;
        private TextBox tbSQLClause;
        private Label label1;
        private Label label2;
        private TextBox tbSeparatorCharacter;
        private Button btnGenerateSQL;
        private CheckBox cbFieldsMustContainValue;
        private Button btnSaveToFile;
        private SaveFileDialog saveFileDialog;
        private Label label3;
        private TextBox tbCommitLineCount;
        private TabControl mainTabControl;
        private TabPage tpSource;
        private TabPage tpResults;
        private TextBox tbResults;
        private Label label4;
    }
}