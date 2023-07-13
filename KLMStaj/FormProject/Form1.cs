using System.Text;

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

            string result = ProcessOperation(selectedValue, textBox1.Text);

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

        public class ComboBoxItem
        {
            public string DisplayMember { get; set; }
            public int ValueMember { get; set; }

            public ComboBoxItem(string displayMember, int valueMember)
            {
                DisplayMember = displayMember;
                ValueMember = valueMember;
            }

            public override string ToString()
            {
                return DisplayMember;
            }
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

        private string ProcessOperation(int selectedValue, string input)
        {
            string result = "";

            switch (selectedValue)
            {
                case 0:
                    if (ValidateInput(input, out int number, out int repeatCount))
                    {
                        result = CustomAlgorithm(number, repeatCount);
                    }
                    else
                    {
                        result = "CustomAlgorithm için geçersiz girdi biçimi. Beklenen biçim: [sayý] [tekrar sayýsý]";
                    }
                    break;
                case 1:
                    if (int.TryParse(input, out int starsNumber))
                    {
                        result = PrintStars(starsNumber);
                    }
                    else
                    {
                        result = "PrintStars için geçersiz girdi biçimi. Beklenen biçim: [sayý]";
                    }
                    break;
                case 2:
                    if (int.TryParse(input, out int divideNumber))
                    {
                        result = DivideByThree(divideNumber);
                    }
                    else
                    {
                        result = "DivideByThree için geçersiz girdi biçimi. Beklenen biçim: [sayý]";
                    }
                    break;
                case 3:
                    result = CompanyMode(input);
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

        private string CustomAlgorithm(int number, int repeatCount)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < repeatCount; i++)
            {
                sb.Append(number + " ");
            }

            return sb.ToString();
        }

        private string PrintStars(int number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                sb.AppendLine(new string('*', i));
            }

            return sb.ToString();
        }

        private string DivideByThree(int number)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;

            for (int i = 3; i <= number; i += 3)
            {
                sb.AppendLine(i.ToString());
                count++;
            }

            sb.Insert(0, "There are " + count + " multiples of 3 up to " + number + Environment.NewLine);

            return sb.ToString();
        }

        private string CompanyMode(string input)
        {
            string filePath = input;

            if (!File.Exists(filePath))
            {
                return "Geçersiz dosya yolu!";
            }

            string[] companyNames = File.ReadAllLines(filePath);
            StringBuilder sb = new StringBuilder();

            foreach (string companyName in companyNames)
            {
                string randomDate = GetRandomDate();
                int randomId = GetRandomId();

                sb.AppendLine("Þirket Adý: " + companyName);
                sb.AppendLine("Kuruluþ Tarihi: " + randomDate);
                sb.AppendLine("ID: " + randomId);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private string GetRandomDate()
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            Random random = new Random();
            int range = (DateTime.Today - startDate).Days;
            DateTime randomDate = startDate.AddDays(random.Next(range));

            return randomDate.ToString("yyyy-MM-dd");
        }

        private int GetRandomId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
