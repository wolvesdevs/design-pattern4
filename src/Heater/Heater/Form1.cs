namespace Heater
{
    public partial class Form1 : Form
    {
        private enum Condition
        {
            OFF,
            Low,
            High
        }
        private Condition _condition = Condition.OFF;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DisplayLabel.Text = _condition.ToString();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            string path = "heater.txt";

            if (_condition == Condition.OFF)
            {
                var list = new List<string>();
                list.Add("Low");
                list.Add("50W");
            }

            var list = new List<string>();
            list.Add("OFF");
            list.Add("0W");
            File.WriteAllLines(path, list);

            DisplayLabel.Text = "OFF";
        }
    }
}