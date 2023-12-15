using Heater.States;
using System.Collections.Generic;

namespace Heater
{
    public partial class Form1 : Form
    {
        private Context _context = new Context();
        //private enum Condition
        //{
        //    OFF,
        //    Low,
        //    High
        //}
        //private Condition _condition = Condition.OFF;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DisplayLabel.Text = _context.GetText();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            //string path = "heater.txt";

            //if (_condition == Condition.OFF)
            //{
            //    var list = new List<string>();
            //    list.Add("Low");
            //    list.Add("500W");
            //    _condition = Condition.Low;
            //    File.WriteAllLines(path, list);
            //}
            //else if (_condition == Condition.Low)
            //{
            //    var list = new List<string>();
            //    list.Add("High");
            //    list.Add("1000W");
            //    _condition = Condition.High;
            //    File.WriteAllLines(path, list);
            //}
            //else if (_condition == Condition.High)
            //{
            //    var list = new List<string>();
            //    list.Add("OFF");
            //    list.Add("0W");
            //    _condition = Condition.OFF;
            //    File.WriteAllLines(path, list);
            //}
            //else
            //{
            //    throw new Exception("error");
            //}

            _context.Up();

            DisplayLabel.Text = _context.GetText();
        }
    }
}