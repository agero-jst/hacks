using System;
using Generators;
using System.Linq;
using System.Windows.Forms;

namespace KeypadWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var r = new Random();
            var coin = r.Next(2);
            InitializeComponent();
            const int columnAmount = 6;
            label.Text = coin == 0 ? "Clockwise" : "Counterclockwise";
            var part = Math.Pow(2, r.Next(4));
            label.Text += @", Parts: " + part;
            var keypadGenerator = new KeyPadGenerator();
            var padRows = keypadGenerator.GenerateKeypad(columnAmount);
            grid.RowHeadersVisible = false;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.Width = 50;
            }
            grid.RowTemplate.Height = 34;
            var pad = padRows.Select(line => new KeypadRow(line)).ToList();
            grid.DataSource = pad;
        }
    }
}
