using Bridge.Devices;
using Bridge.Measures;

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
            Device device = new AcDevice(new TempMeasure());
            NameLabel.Text = device.GetName();
            MeasureLabel.Text = device.GetMeasure();
            KandoLabel.Text = device.GetKando();
            BatteryLevelLabel.Text = device.GetBatteryLeval();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Device device = new AcDevice(new WindMeasure());
            NameLabel.Text = device.GetName();
            MeasureLabel.Text = device.GetMeasure();
            KandoLabel.Text = device.GetKando();
            BatteryLevelLabel.Text = device.GetBatteryLeval();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Device device = new BatteryDevice(new TempMeasure());
            NameLabel.Text = device.GetName();
            MeasureLabel.Text = device.GetMeasure();
            KandoLabel.Text = device.GetKando();
            BatteryLevelLabel.Text = device.GetBatteryLeval();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Device device = new BatteryDevice(new WindMeasure());
            NameLabel.Text = device.GetName();
            MeasureLabel.Text = device.GetMeasure();
            KandoLabel.Text = device.GetKando();
            BatteryLevelLabel.Text = device.GetBatteryLeval();
        }
    }
}
