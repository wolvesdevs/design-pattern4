using DDD.Objects;

namespace DDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var component = new ComponentA(radioButton2.Checked, radioButton3.Checked);
            var value = component.GetData();
            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var component = new ComponentB(radioButton2.Checked, radioButton3.Checked);
            var value = component.GetData();
            button2.Text = value;
        }
    }
}