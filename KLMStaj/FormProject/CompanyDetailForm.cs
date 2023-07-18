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
                List<Company> companies = new List<Company>();

                companies.Add(new Company());

                this.Close();
            }
      
        }
    }
}
