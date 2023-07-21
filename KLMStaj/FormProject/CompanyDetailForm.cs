using BusinessProject;
using ModelProject;
using System.Text;

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
            else if (txtCompanyName.Text.Equals("Şirket adı boş olamaz. Lütfen şirket adını giriniz."))
                txtCompanyName.Text = null;
            else
            {
                CompanyManager companyManager = new CompanyManager();
                Company company = companyManager.CreateCompany(companyName);
                MainForm.companies.Add(company);


                StringBuilder resultText = new StringBuilder();
                var query = from companyItem in MainForm.companies
                            select companyItem;

                foreach (var companyItem in query)
                {
                    resultText.AppendLine($"\r\n{companyItem.Id} - {companyItem.Name} - {companyItem.FoundationDate}");
                }

                MainForm.txtResult.Text = resultText.ToString();
            }
            this.Close();
        }
    }
}

