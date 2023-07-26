using ModelProject;

namespace FormProject
{
    public partial class UpdateCompanyForm : Form
    {
        private Company selectedCompany;
        private MainForm _mainFormRef;
        public UpdateCompanyForm(Company selectedCompany, MainForm mainFormRef)
        {
            InitializeComponent();

            this.selectedCompany = selectedCompany;
            this._mainFormRef = mainFormRef;

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
                using (var dbContext = new BusinessProject.CompanyDbContext())
                {
                    DataGridViewRow selectedRow = _mainFormRef.gridResult.SelectedRows[0];
                    Company selectedCompany = selectedRow.DataBoundItem as Company;

                    var companyToUpdate = dbContext.Companies.Find(selectedCompany.Id);
                    if (companyToUpdate != null)
                    {
                        companyToUpdate.Name = newCompanyName;
                        companyToUpdate.FoundationDate = newFoundationDate;

                        dbContext.SaveChanges();
                    }

                    _mainFormRef.gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    _mainFormRef.gridResult.DataSource = null;
                    _mainFormRef.gridResult.DataSource = dbContext.Companies.ToList();
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
