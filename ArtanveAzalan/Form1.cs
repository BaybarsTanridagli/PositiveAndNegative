namespace ArtanveAzalan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label2.Text);
            int miktar = Convert.ToInt32(numericUpDown1.Value);
            if (radioButton1.Checked == true)
            {
                sayi = sayi + miktar;
            }
            else
            {
                sayi = sayi - miktar;
            }
            label2.Text = sayi.ToString();
        }
    }
}