using ModelProject;

namespace FormProject
{
    public partial class UpdateCompanyForm : Form
    {
        private MainForm _mainFormRef;
        public UpdateCompanyForm(MainForm mainFormRef)
        {
            InitializeComponent();

            if (mainFormRef == null)
            {
                throw new Exception("mainForm boş geçilemez");
            }
            _mainFormRef = mainFormRef;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string newCompanyName = txtNewName.Text;
            DateTime newFoundationDate = newDate.Value;

            if (string.IsNullOrWhiteSpace(newCompanyName))
            {
                txtNewName.Text = "Şirket adı boş olamaz. Lütfen şirket adını giriniz.";
                return;
            }
            else if (txtNewName.Text.Equals("Şirket adı boş olamaz. Lütfen şirket adını giriniz."))
                txtNewName.Text = null;
            else
            {
                DataGridViewRow selectedRow = _mainFormRef.gridResult.SelectedRows[0];
                Company selectedCompany = selectedRow.DataBoundItem as Company;
                MainForm.companies.Remove(selectedCompany);
                Company updatedCompany = new Company { Id = selectedCompany.Id, Name = newCompanyName, FoundationDate = newFoundationDate };
                MainForm.companies.Add(updatedCompany);

                _mainFormRef.gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                _mainFormRef.gridResult.DataSource = null;
                _mainFormRef.gridResult.DataSource = MainForm.companies;
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
