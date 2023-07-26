using ModelProject;
using UtilityProject;

namespace FormProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
          /*  using (var dbContext = new BusinessProject.CompanyDbContext())
            {
                var companies = dbContext.Companies.ToList();
                gridResult.DataSource = companies;
            }*/

            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)cmbProcessSelect.SelectedItem;
            int selectedValue = selectedComboBoxItem.ValueMember;

            string? result = ProcessOperation(selectedValue, txtCommand.Text);

            txtResult.Text = result;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)cmbProcessSelect.SelectedItem;
            cmbProcessSelect.DisplayMember = "DisplayMember";
            cmbProcessSelect.ValueMember = "ValueMember";
            cmbProcessSelect.DataSource = ComboBoxItem.GetComboBoxData();
        }

        private string? ProcessOperation(int selectedValue, string input)
        {
            AlgorithmHelper algorithmHelper = new AlgorithmHelper();
            string? result = null;

            switch (selectedValue)
            {
                case 0:
                    if (ValidateInput(input, out int number, out int repeatCount))
                    {
                        result = algorithmHelper.CustomAlgorithm(number, repeatCount);
                    }
                    else
                    {
                        result = "CustomAlgorithm için geçersiz girdi biçimi. Beklenen biçim: [sayý] [tekrar sayýsý]";
                    }
                    break;
                case 1:
                    if (int.TryParse(input, out int starsNumber))
                    {
                        result = algorithmHelper.PrintStars(starsNumber);
                    }
                    else
                    {
                        result = "PrintStars için geçersiz girdi biçimi. Beklenen biçim: [sayý]";
                    }
                    break;
                case 2:
                    if (int.TryParse(input, out int divideNumber))
                    {
                        result = algorithmHelper.DivideByThree(divideNumber);
                    }
                    else
                    {
                        result = "DivideByThree için geçersiz girdi biçimi. Beklenen biçim: [sayý]";
                    }
                    break;
                case 3:
                    string filePath = txtCommand.Text;
                    result = algorithmHelper.CompanyMode(filePath);
                    break;
                default:
                    break;
            }

            return result;
        }

        private bool ValidateInput(string input, out int number, out int repeatCount)
        {
            number = 0;
            repeatCount = 0;

            string[] inputValues = input.Split(' ');

            if (inputValues.Length != 2)
            {
                return false;
            }

            if (!int.TryParse(inputValues[0], out number) || !int.TryParse(inputValues[1], out repeatCount))
            {
                return false;
            }

            return true;
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

                    gridResult.DataSource = null;
                    gridResult.DataSource = dbContext.Companies.ToList();
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
    }
}
