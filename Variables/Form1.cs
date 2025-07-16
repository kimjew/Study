namespace Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int iValue = 100;
             lbResult.Text = iValue.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double fValue = 3.14;
            lbResult.Text = fValue.ToString();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string sValue = "Àá¼öÇÔ";
            lbResult.Text = sValue;
        }
    }
}
