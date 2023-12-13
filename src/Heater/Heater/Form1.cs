namespace Heater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DisplayLabel.Text = "";
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            string path = "heater.txt";
            var list = new List<string>();
            list.Add("OFF");
            list.Add("0W");
            File.WriteAllLines(path, list);

            DisplayLabel.Text = "OFF";
        }
    }
}