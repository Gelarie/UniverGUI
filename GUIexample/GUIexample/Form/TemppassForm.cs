using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIexample
{
    public partial class TemppassForm : Form
    {
        public TemppassForm()
        {
            //InitializeComponent();
            Dictionary<int, string> dictUK = new Dictionary<int, string>();
            dictUK.Add(1, "Petrov");
            dictUK.Add(2, "Ivanov");
            dictUK.Add(3, "Sidorov");

            int TF = 500;
            var title = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Временный пропуск"
            };




            var labeltext = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Введите фамилию"
            };


            var lastname = new TextBox()
            {
                Dock = DockStyle.Fill
            };


            var receipt = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Получить"
            };


            var back = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Назад"
            };
            var table = new TableLayoutPanel();

            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            table.Dock = DockStyle.Fill;

            table.Controls.Add(title, 0, 0);
            table.Controls.Add(labeltext, 0, 1);
            table.Controls.Add(lastname, 0, 2);
            table.Controls.Add(receipt, 0, 3);
            table.Controls.Add(back, 0, 4);
            Controls.Add(table);

            //receipt.Click += new EventHandler(this.Receipt_Click);
            back.Click += new EventHandler(this.Back_Click);
        }
       // private void Receipt_Click(object sender, EventArgs e)
       // {
       //     dictUK.Add(TF++, lastname.Text);
       //     MessageBox.Show("ОК");
       //     using (System.IO.StreamWriter file =
       //new System.IO.StreamWriter("pass.txt", true))
       //     {
       //         file.WriteLine(lastname.Text + " получил " + title.Text);
       //     }
       // }

        private void Back_Click(object sender, EventArgs e)
        {
            Form Start = new Start();
            Start.Show();
            this.Hide();
        }

    }
}
