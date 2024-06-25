using BLL;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = await BLL.TextFun.findWordAsync(textBox1.Text);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = await BLL.TextFun.AllBibleAsync();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = await BLL.TextFun.countWordAsync(textBox2.Text);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
           listBox1.DataSource = await BLL.TextFun.nameAsync(textBox3.Text);
        }
    }
}