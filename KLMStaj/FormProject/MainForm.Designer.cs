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
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.White;
            btnProcess.Cursor = Cursors.Hand;
            btnProcess.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcess.ForeColor = Color.OliveDrab;
            btnProcess.Location = new Point(418, 438);
            btnProcess.Margin = new Padding(3, 4, 3, 4);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(86, 31);
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
            txtCommand.Size = new Size(414, 28);
            txtCommand.TabIndex = 1;
            // 
            // cmbProcessSelect
            // 
            cmbProcessSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProcessSelect.FormattingEnabled = true;
            cmbProcessSelect.Items.AddRange(new object[] { "CustomAlgorithm", "PrintStarts", "DivideByThree", "CompanyMode" });
            cmbProcessSelect.Location = new Point(566, 69);
            cmbProcessSelect.Name = "cmbProcessSelect";
            cmbProcessSelect.Size = new Size(192, 28);
            cmbProcessSelect.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(146, 103);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(612, 328);
            txtResult.TabIndex = 3;
            // 
            // btnCreateCompany
            // 
            btnCreateCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCompany.ForeColor = Color.FromArgb(0, 0, 64);
            btnCreateCompany.Location = new Point(537, 438);
            btnCreateCompany.Name = "btnCreateCompany";
            btnCreateCompany.Size = new Size(221, 31);
            btnCreateCompany.TabIndex = 4;
            btnCreateCompany.Text = "Create Company";
            btnCreateCompany.UseVisualStyleBackColor = true;
            btnCreateCompany.Click += btnCreateCompany_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 502);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcess;
        private BindingSource mainFormBindingSource;
        private TextBox txtCommand;
        private ComboBox cmbProcessSelect;
        private TextBox txtResult;
        private Button btnCreateCompany;
    }
}