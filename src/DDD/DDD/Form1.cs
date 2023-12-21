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
            var component = new ComponentA(radioButton2.Checked);
            var value = component.GetData();
            button1.Text = value;
        }
    }
}
