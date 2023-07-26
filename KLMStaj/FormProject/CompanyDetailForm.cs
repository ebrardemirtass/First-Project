using BusinessProject;
using ModelProject;

namespace FormProject
{
    public partial class CompanyDetailForm : Form
    {
        private MainForm _mainFormRef;

        public CompanyDetailForm(MainForm mainFormRef)
        {
            InitializeComponent();

            if (mainFormRef == null)
            {
                throw new Exception("mainForm boş geçilemez");
            }

            _mainFormRef = mainFormRef;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;

            if (string.IsNullOrWhiteSpace(companyName))
            {
                txtCompanyName.Text = "Şirket adı boş olamaz. Lütfen şirket adını giriniz.";
                return;
            }
            else if (txtCompanyName.Text.Equals("Şirket adı boş olamaz. Lütfen şirket adını giriniz."))
                txtCompanyName.Text = null;
            else
            {
                CompanyManager companyManager = new CompanyManager();
                Company company = companyManager.CreateCompany(companyName);
                CompanyDbContext dbContext = new CompanyDbContext();
                dbContext.Companies.Add(company);
                _mainFormRef.gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                _mainFormRef.gridResult.DataSource = null;
                _mainFormRef.gridResult.DataSource = dbContext.Companies.ToList();

            }
            this.Close();
        }
    }
}

