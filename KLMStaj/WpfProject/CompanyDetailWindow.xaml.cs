using BusinessProject;
using ModelProject;
using System;
using System.Windows;

namespace WpfProject
{
    /// <summary>
    /// CompanyDetailWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class CompanyDetailWindow : Window
    {
        private MainWindow _mainWindowRef;
        public CompanyDetailWindow(MainWindow mainWindowRef)
        {
            InitializeComponent();

            if (mainWindowRef == null)
            {
                throw new Exception("mainForm boş geçilemez");
            }
            _mainWindowRef = mainWindowRef;
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
                _mainWindowRef.ReloadGrid();
            }
            this.Close();
        }
    }
}



