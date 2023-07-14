namespace FormProject
{
    internal class ComboBoxItem
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
}
