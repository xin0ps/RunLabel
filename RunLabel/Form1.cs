namespace RunLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
         
        {
            int a = Random.Shared.Next(0, 255);
            int b = Random.Shared.Next(0, 255);
            int c = Random.Shared.Next(0, 255);
            label1.ForeColor= Color.FromArgb(a,b,c);

            label1.Location = new Point(a, b);
        }
    }
}