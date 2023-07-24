namespace FormProject
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnProcess = new Button();
            mainFormBindingSource = new BindingSource(components);
            txtCommand = new TextBox();
            cmbProcessSelect = new ComboBox();
            txtResult = new TextBox();
            btnCreateCompany = new Button();
            gridResult = new DataGridView();
            btnDeleteCompany = new Button();
            btnUpdateCompany = new Button();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridResult).BeginInit();
            SuspendLayout();
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.White;
            btnProcess.Cursor = Cursors.Hand;
            btnProcess.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcess.ForeColor = SystemColors.ActiveCaptionText;
            btnProcess.Location = new Point(658, 69);
            btnProcess.Margin = new Padding(3, 4, 3, 4);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(100, 31);
            btnProcess.TabIndex = 0;
            btnProcess.Text = "Search";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.UseWaitCursor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(MainForm);
            // 
            // txtCommand
            // 
            txtCommand.Location = new Point(146, 69);
            txtCommand.Multiline = true;
            txtCommand.Name = "txtCommand";
            txtCommand.Size = new Size(328, 28);
            txtCommand.TabIndex = 1;
            // 
            // cmbProcessSelect
            // 
            cmbProcessSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProcessSelect.FormattingEnabled = true;
            cmbProcessSelect.Items.AddRange(new object[] { "CustomAlgorithm", "PrintStarts", "DivideByThree", "CompanyMode" });
            cmbProcessSelect.Location = new Point(480, 69);
            cmbProcessSelect.Name = "cmbProcessSelect";
            cmbProcessSelect.Size = new Size(172, 28);
            cmbProcessSelect.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(146, 103);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(612, 158);
            txtResult.TabIndex = 3;
            // 
            // btnCreateCompany
            // 
            btnCreateCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCompany.ForeColor = Color.FromArgb(0, 0, 64);
            btnCreateCompany.Location = new Point(146, 438);
            btnCreateCompany.Name = "btnCreateCompany";
            btnCreateCompany.Size = new Size(198, 31);
            btnCreateCompany.TabIndex = 4;
            btnCreateCompany.Text = "Create Company";
            btnCreateCompany.UseVisualStyleBackColor = true;
            btnCreateCompany.Click += btnCreateCompany_Click;
            // 
            // gridResult
            // 
            gridResult.BackgroundColor = Color.Thistle;
            gridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResult.Location = new Point(146, 267);
            gridResult.Name = "gridResult";
            gridResult.RowHeadersWidth = 51;
            gridResult.RowTemplate.Height = 29;
            gridResult.Size = new Size(612, 165);
            gridResult.TabIndex = 5;
            // 
            // btnDeleteCompany
            // 
            btnDeleteCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCompany.ForeColor = Color.Crimson;
            btnDeleteCompany.Location = new Point(560, 438);
            btnDeleteCompany.Name = "btnDeleteCompany";
            btnDeleteCompany.Size = new Size(198, 31);
            btnDeleteCompany.TabIndex = 6;
            btnDeleteCompany.Text = "Delete Company";
            btnDeleteCompany.UseVisualStyleBackColor = true;
            btnDeleteCompany.Click += btnDeleteCompany_Click;
            // 
            // btnUpdateCompany
            // 
            btnUpdateCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCompany.ForeColor = Color.Indigo;
            btnUpdateCompany.Location = new Point(350, 438);
            btnUpdateCompany.Name = "btnUpdateCompany";
            btnUpdateCompany.Size = new Size(198, 31);
            btnUpdateCompany.TabIndex = 7;
            btnUpdateCompany.Text = "Update Company";
            btnUpdateCompany.UseVisualStyleBackColor = true;
            btnUpdateCompany.Click += btnUpdateCompany_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 502);
            Controls.Add(btnUpdateCompany);
            Controls.Add(btnDeleteCompany);
            Controls.Add(gridResult);
            Controls.Add(btnCreateCompany);
            Controls.Add(txtResult);
            Controls.Add(cmbProcessSelect);
            Controls.Add(txtCommand);
            Controls.Add(btnProcess);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcess;
        private BindingSource mainFormBindingSource;
        private TextBox txtCommand;
        private ComboBox cmbProcessSelect;
        public TextBox txtResult;
        private Button btnCreateCompany;
        public DataGridView gridResult;
        private Button btnDeleteCompany;
        private Button btnUpdateCompany;
    }
}