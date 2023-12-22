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
            var component = new ComponentA();
            string value = "";

            if (radioButton2.Checked)
            {
                value = component.GetDataUpper();
            }
            else
            {
                value = component.GetData();
            }

            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var component = new ComponentB();

            //if (radioButton2.Checked)
            //{
            //    component = new ComponentBUpper();
            //}
            //else if (radioButton3.Checked)
            //{
            //    component = new ComponentBLower();
            //}

            //var value = component.GetData();
            //button2.Text = value;
        }
    }
}
