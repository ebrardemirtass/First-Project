namespace FormProject
{
    partial class UpdateCompanyForm
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
            btnSave = new Button();
            btnCancel = new Button();
            txtNewName = new TextBox();
            lblNameComment = new Label();
            lblDateComment = new Label();
            newDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(238, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(407, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(173, 176);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(434, 27);
            txtNewName.TabIndex = 2;
            // 
            // lblNameComment
            // 
            lblNameComment.AutoSize = true;
            lblNameComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNameComment.ForeColor = SystemColors.ControlLightLight;
            lblNameComment.Location = new Point(175, 147);
            lblNameComment.Name = "lblNameComment";
            lblNameComment.Size = new Size(160, 20);
            lblNameComment.TabIndex = 4;
            lblNameComment.Text = "New Company Name";
            // 
            // lblDateComment
            // 
            lblDateComment.AutoSize = true;
            lblDateComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDateComment.ForeColor = SystemColors.ControlLightLight;
            lblDateComment.Location = new Point(175, 214);
            lblDateComment.Name = "lblDateComment";
            lblDateComment.Size = new Size(237, 20);
            lblDateComment.TabIndex = 5;
            lblDateComment.Text = "New Company Faundation Date";
            // 
            // newDate
            // 
            newDate.Format = DateTimePickerFormat.Short;
            newDate.Location = new Point(173, 237);
            newDate.Name = "newDate";
            newDate.Size = new Size(434, 27);
            newDate.TabIndex = 6;
            newDate.Value = new DateTime(2023, 7, 24, 0, 0, 0, 0);
            // 
            // UpdateCompanyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(newDate);
            Controls.Add(lblDateComment);
            Controls.Add(lblNameComment);
            Controls.Add(txtNewName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "UpdateCompanyForm";
            Text = "UpdateCompanyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtNewName;
        private TextBox txtNewDate;
        private Label lblNameComment;
        private Label lblDateComment;
        private DateTimePicker newDate;
    }
}