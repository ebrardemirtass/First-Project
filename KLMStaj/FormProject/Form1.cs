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
            MessageBox.Show("Button Clicked");
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

    }
}