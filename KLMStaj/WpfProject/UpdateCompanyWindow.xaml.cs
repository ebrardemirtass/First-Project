using ModelProject;
using System;
using System.Windows;

namespace WpfProject
{
    /// <summary>
    /// UpdateCompanyWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class UpdateCompanyWindow : Window
    {
        private Company selectedCompany;
        private MainWindow _mainWindowRef;
        public UpdateCompanyWindow(MainWindow mainWindowRef)
        {
            InitializeComponent();

            this.selectedCompany = selectedCompany;
            this._mainWindowRef = mainWindowRef;

            if (mainWindowRef == null)
            {
                throw new Exception("mainForm boş geçilemez");
            }
            _mainWindowRef = mainWindowRef;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string? newCompanyName = txtNewName.Text;
            if (string.IsNullOrWhiteSpace(newCompanyName) || !newDate.SelectedDate.HasValue)
            {
                txtNewName.Text = "Şirket adı ya da tarih boş olamaz. Lütfen bilgileri eksiksiz giriniz.";
                return;
            }
            else if (txtNewName.Text.Equals("Şirket adı ya da tarih boş olamaz. Lütfen bilgileri eksiksiz giriniz."))
            {
                txtNewName.Text = null;
            }
            else
            {
                using (var dbContext = new BusinessProject.CompanyDbContext())
                {
                    if (_mainWindowRef.gridResult.SelectedItems.Count > 0)
                    {
                        DateTime newFoundationDate = newDate.SelectedDate.Value;
                        var selectedCompany = _mainWindowRef.gridResult.SelectedItems[0] as Company;
                        var companyToUpdate = dbContext.Companies.Find(selectedCompany.Id);
                        if (companyToUpdate != null)
                        {
                            companyToUpdate.Name = newCompanyName;
                            companyToUpdate.FoundationDate = newFoundationDate;
                            dbContext.SaveChanges();
                            _mainWindowRef.ReloadGrid();
                        }
                    }
                }
            }

            this.Close();
        }
    }
}
