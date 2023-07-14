using UtilityProject;

namespace FormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)comboBox1.SelectedItem;
            int selectedValue = selectedComboBoxItem.ValueMember;

            string? result = ProcessOperation(selectedValue, textBox1.Text);

            textBox1.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "DisplayMember";
            comboBox1.ValueMember = "ValueMember";
            comboBox1.DataSource = GetComboBoxData();
        }

        private List<ComboBoxItem> GetComboBoxData()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();

            comboBoxItems.Add(new ComboBoxItem("CustomAlgorithm", 0));
            comboBoxItems.Add(new ComboBoxItem("PrintStarts", 1));
            comboBoxItems.Add(new ComboBoxItem("DivideByThree", 2));
            comboBoxItems.Add(new ComboBoxItem("CompanyMode", 3));

            return comboBoxItems;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBoxItem selectedComboBoxItem = (ComboBoxItem)comboBox1.SelectedItem;
            int selectedValue = selectedComboBoxItem.ValueMember;
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
                    string filePath = textBox1.Text;
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
