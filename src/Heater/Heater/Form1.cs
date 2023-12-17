using Heater.States;
using System.Collections.Generic;

namespace Heater
{
    public partial class Form1 : Form
    {
        private Context _context = new Context();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DisplayLabel.Text = _context.GetText();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            _context.Up();
            DisplayLabel.Text = _context.GetText();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            _context.Down();
            DisplayLabel.Text = _context.GetText();
        }
    }
}