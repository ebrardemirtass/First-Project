using BusinessProject;
using ModelProject;

namespace FormProject
{
    public partial class CompanyDetailForm : Form
    {
        public CompanyDetailForm()
        {
            InitializeComponent();
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
            else
            {
                CompanyManager companyManager = new CompanyManager();
                Company company = companyManager.CreateCompany(companyName);
                MainForm.companies.Add(company);

                MainForm.txtResult.Text += $"\r\n{company.Id} - {company.Name} - {company.FoundationDate}";

                this.Close();
            }
        }
    }
}
