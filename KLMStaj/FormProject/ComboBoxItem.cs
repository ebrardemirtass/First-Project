namespace FormProject
{
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

        public static List<ComboBoxItem> GetComboBoxData()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();

            comboBoxItems.Add(new ComboBoxItem("CustomAlgorithm", 0));
            comboBoxItems.Add(new ComboBoxItem("PrintStarts", 1));
            comboBoxItems.Add(new ComboBoxItem("DivideByThree", 2));
            comboBoxItems.Add(new ComboBoxItem("CompanyMode", 3));

            return comboBoxItems;
        }

        public static List<ComboBoxItem> GetComboBoxData2()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();

            comboBoxItems.Add(new ComboBoxItem("Son 10 yılda kurulan şirketleri göster", 0));
            comboBoxItems.Add(new ComboBoxItem("İsmi F ile başlayan şirketleri göster", 1));
            comboBoxItems.Add(new ComboBoxItem("Adında X yada E bulunan şirketleri göster", 2));

            return comboBoxItems;
        }

    }
}
