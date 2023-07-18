namespace FormProject
{
    partial class CompanyDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyDetailForm));
            txtCompanyName = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.OldLace;
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Location = new Point(160, 110);
            txtCompanyName.Multiline = true;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(481, 201);
            txtCompanyName.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.Font = new Font("Dubai", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.Menu;
            btnClose.Location = new Point(570, 69);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = " X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.SteelBlue;
            btnSave.Location = new Point(359, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CompanyDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 419);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtCompanyName);
            Name = "CompanyDetailForm";
            Text = "CompanyDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private Button btnClose;
        private Button btnSave;
    }
}