using Bogus;
using BusinessProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using UtilityProject;
using ComboBoxItem = UtilityProject.ComboBoxItem;
using Company = ModelProject.Company;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReloadGrid();
            LoadComboBoxData();
        }

        public void ReloadGrid()
        {
            using (var dbContext = new CompanyDbContext())
            {
                var companies = dbContext.Companies.ToList();
                gridResult.ItemsSource = null;
                gridResult.ItemsSource = companies;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (cmbProcessSelect.SelectedItem is ComboBoxItem selectedComboBoxItem)
            {
                Operations operations = new Operations();

                int selectedValue = selectedComboBoxItem.ValueMember;

                string? result = operations.ProcessOperation(selectedValue, txtCommand.Text);

                txtResult.Text = result;
            }
        }

        private void LoadComboBoxData()
        {
            cmbProcessSelect.ItemsSource = ComboBoxItem.GetComboBoxData();
            cmbProcessSelect.DisplayMemberPath = "DisplayMember";
            cmbProcessSelect.SelectedValuePath = "ValueMember";

            cmbLINQOperation.ItemsSource = ComboBoxItem.GetComboBoxData2();
            cmbLINQOperation.DisplayMemberPath = "DisplayMember";
            cmbLINQOperation.SelectedValuePath = "ValueMember";
        }

        private void btnFakeCompany_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new CompanyDbContext())
            {
                var faker = new Faker<Company>()
                    .RuleFor(x => x.Name, f => f.Company.CompanyName())
                    .RuleFor(x => x.FoundationDate, f => f.Date.Past());

                var companies = faker.Generate(100);

                dbContext.Companies.AddRange(companies);
                dbContext.SaveChanges();
                ReloadGrid();
            }
        }

        private void btnCreateCompany_Click(object sender, RoutedEventArgs e)
        {
            CompanyDetailWindow companyDetailWindow = new CompanyDetailWindow(this);
            companyDetailWindow.Show();
        }

        private void btnUpdateCompany_Click(object sender, RoutedEventArgs e)
        {
            UpdateCompanyWindow updateCompanyWindow = new UpdateCompanyWindow(this);
            updateCompanyWindow.Show();
        }
        private void btnDeleteCompany_Click(object sender, RoutedEventArgs e)
        {
            if (gridResult.SelectedItems.Count > 0)
            {
                using (var dbContext = new CompanyDbContext())
                {
                    foreach (var selectedItem in gridResult.SelectedItems)
                    {
                        if (selectedItem is Company selectedCompany)
                        {
                            var companyToDelete = dbContext.Companies.Find(selectedCompany.Id);
                            if (companyToDelete != null)
                            {
                                dbContext.Companies.Remove(companyToDelete);
                            }
                        }
                    }

                    dbContext.SaveChanges();
                    ReloadGrid();
                }
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            if (cmbLINQOperation.SelectedItem is ComboBoxItem selectedComboBoxItem2)
            {
                int selectedValue = selectedComboBoxItem2.ValueMember;
                Operations operations = new Operations();

                List<Company>? resultList = operations.LINQOperation(selectedValue);
                gridResult.ItemsSource = null;
                gridResult.ItemsSource = resultList?.ToList();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cmbProcessSelect.SelectedItem is ComboBoxItem selectedComboBoxItem)
            {
                Operations operations = new Operations();

                int selectedValue = selectedComboBoxItem.ValueMember;
                string? result = operations.ProcessOperation(selectedValue, txtCommand.Text);

                txtResult.Text = result;
            }
        }
    }
}

