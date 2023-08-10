using Bogus;
using BusinessProject;
using System.Buffers;
using UtilityProject;
using Company = ModelProject.Company;

namespace FormProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void ReloadGrid()
        {
            var dbContext = new CompanyDbContext();
            gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridResult.DataSource = null;
            gridResult.DataSource = dbContext.Companies.ToList();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Operations operations= new Operations();
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)cmbProcessSelect.SelectedItem;
            int selectedValue = selectedComboBoxItem.ValueMember;

            string? result = operations.ProcessOperation(selectedValue, txtCommand.Text);

            txtResult.Text = result;
        }

       
        private void btnFilter_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            ComboBoxItem selectedComboBoxItem2 = (ComboBoxItem)cmbLINQOperation.SelectedItem;
            int selectedValue = selectedComboBoxItem2.ValueMember;

            List<Company>? resultList = operations.LINQOperation(selectedValue);

            gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridResult.DataSource = null;
            gridResult.DataSource = resultList.ToList();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var dbContext = new CompanyDbContext())
            {
                ReloadGrid();
            }
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)cmbProcessSelect.SelectedItem;
            cmbProcessSelect.DisplayMember = "DisplayMember";
            cmbProcessSelect.ValueMember = "ValueMember";
            cmbProcessSelect.DataSource = ComboBoxItem.GetComboBoxData();

            ComboBoxItem selectedComboBoxItem2 = (ComboBoxItem)cmbLINQOperation.SelectedItem;
            cmbLINQOperation.DisplayMember = "DisplayMember";
            cmbLINQOperation.ValueMember = "ValueMember";
            cmbLINQOperation.DataSource = ComboBoxItem.GetComboBoxData2();
        }

        private void btnCreateCompany_Click(object sender, EventArgs e)
        {
            CompanyDetailForm companyDetailForm = new CompanyDetailForm(this);
            companyDetailForm.Show();
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            if (gridResult.SelectedRows.Count > 0)
            {
                using (var dbContext = new BusinessProject.CompanyDbContext())
                {
                    for (int i = 0; i < gridResult.SelectedRows.Count; i++)
                    {
                        DataGridViewRow selectedRow = gridResult.SelectedRows[i];
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

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            if (gridResult.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridResult.SelectedRows[0];
                Company selectedCompany = selectedRow.DataBoundItem as Company;

                UpdateCompanyForm updateCompanyForm = new UpdateCompanyForm(selectedCompany, this);
                updateCompanyForm.Show();
            }
        }

        private void btnFakeCompany_Click(object sender, EventArgs e)
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
    }
}
