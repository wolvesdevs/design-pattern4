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
            else if (radioButton3.Checked)
            {
                component = new DecoratorLower(component);
            }

            string value = component.GetData();
            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IComponent component = new ComponentB();

            if (radioButton2.Checked)
            {
                component = new DecoratorUpper(component);
            }
            else if (radioButton3.Checked)
            {
                component = new DecoratorLower(component);
            }

            string value = component.GetData();
            button2.Text = value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IComponent component = new ComponentB();
            component = new DecoratorUpper(component);
            component = new DecoratorLower(component);
            button3.Text = component.GetPrice().ToString();
        }
    }
}
