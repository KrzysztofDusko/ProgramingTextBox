namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fastColoredTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Delete | Keys.Control))
            {
                fastColoredTextBox1.OpenFile(@"C:\Users\dusko\source\repos\ProgramingTextBox\wadliwyPlikZanonimizowany.sql");
            }
        }
    }
}