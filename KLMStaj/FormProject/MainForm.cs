using ModelProject;
using UtilityProject;

namespace FormProject
{
    public partial class MainForm : Form
    {
        public static List<Company> companies = new List<Company>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
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
    }
}
