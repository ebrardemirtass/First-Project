using Bogus;
using BusinessProject;
using FormProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using ComboBoxItem = FormProject.ComboBoxItem;
using Company = ModelProject.Company;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainForm _mainFormRef;
        public MainWindow(MainForm mainFormRef)
        {
            InitializeComponent();
            ReloadGrid();
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
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)cmbProcessSelect.SelectedItem;
            int selectedValue = selectedComboBoxItem.ValueMember;

            string? result = _mainFormRef.ProcessOperation(selectedValue, txtCommand.Text);

            txtResult.Text = result;
        }

        private List<Company> resultList = new List<Company>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var dbContext = new CompanyDbContext())
            {
                ReloadGrid();

                List<ComboBoxItem> processItems = ComboBoxItem.GetComboBoxData();
                cmbProcessSelect.ItemsSource = processItems;
                cmbProcessSelect.DisplayMemberPath = "DisplayMember";
                cmbProcessSelect.SelectedValuePath = "ValueMember";

                List<ComboBoxItem> linqOperationItems = ComboBoxItem.GetComboBoxData2();
                cmbLINQOperation.ItemsSource = linqOperationItems;
                cmbLINQOperation.DisplayMemberPath = "DisplayMember";
                cmbLINQOperation.SelectedValuePath = "ValueMember";
            }
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
            /*  DÜZENLENECEK!
                 CompanyDetailForm companyDetailForm = new CompanyDetailForm(this);
                 companyDetailForm.Show();
            */

        }

        private void btnUpdateCompany_Click(object sender, RoutedEventArgs e)
        {
            /* DÜZENLENECEK!
            if (gridResult.SelectedItems.Count > 0)
            {
                DataGridViewRow selectedRow = (DataGridViewRow)gridResult.SelectedItems[0];
                Company selectedCompany = selectedRow.DataBoundItem as Company;

                UpdateCompanyForm updateCompanyForm = new UpdateCompanyForm(selectedCompany, this);
                updateCompanyForm.Show();
            }
            */
        }

        private void btnDeleteCompany_Click(object sender, RoutedEventArgs e)
        {
            if (gridResult.SelectedItems.Count > 0)
            {
                using (var dbContext = new CompanyDbContext())
                {
                    for (int i = 0; i < gridResult.SelectedItems.Count; i++)
                    {
                        DataGridViewRow selectedRow = (DataGridViewRow)gridResult.SelectedItems[i];
                        Company selectedCompany = selectedRow.DataBoundItem as Company;

                        var companyToDelete = dbContext.Companies.Find(selectedCompany.Id);
                        if (companyToDelete != null)
                        {
                            dbContext.Companies.Remove(companyToDelete);
                        }
                    }

                    dbContext.SaveChanges();
                    ReloadGrid();
                }
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedComboBoxItem2 = (ComboBoxItem)cmbLINQOperation.SelectedItem;
            int selectedValue = selectedComboBoxItem2.ValueMember;

            List<Company>? resultList = _mainFormRef.LINQOperation(selectedValue);
            gridResult.ItemsSource = null;
            gridResult.ItemsSource = resultList.ToList();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)cmbProcessSelect.SelectedItem;
            int selectedValue = selectedComboBoxItem.ValueMember;

            string? result = _mainFormRef.ProcessOperation(selectedValue, txtCommand.Text);

            txtResult.Text = result;
        }
    }
}

