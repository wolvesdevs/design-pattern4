using Bridge.Devices;

namespace Bridge
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
            var device = new TempDevice();
            NameLabel.Text = device.GetName();
            MeasureLabel.Text = device.GetMeasure();
            KandoLabel.Text = device.GetKando();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var device = new WindDevice();
            NameLabel.Text = device.GetName();
            MeasureLabel.Text = device.GetMeasure();
            KandoLabel.Text = device.GetKando();
        }
    }
}
