using DDDCom.Messages;

namespace DDDCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            var measureId = Convert.ToInt32(textBox1.Text);
            var message = new MeasureMessage(measureId);
            listBox1.Items.Add(string.Join("-", message.GetBytes()));
        }
    }
}
