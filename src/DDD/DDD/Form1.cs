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
            IComponent component = new ComponentA();

            if (radioButton2.Checked)
            {
                component = new DecoratorUpper(component);
            }

            string value = component.GetData();
            button1.Text = value;
        }
    }
}
