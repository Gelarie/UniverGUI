using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUIexample
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            //InitializeComponent();
            Dictionary<int, string> dictUK = new Dictionary<int, string>();
            dictUK.Add(1, "Petrov");
            dictUK.Add(2, "Ivanov");
            dictUK.Add(3, "Sidorov");

            var title = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Охрана"
            };


            var labeltext = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Введите идентификатор"
            };


            var field = new TextBox()
            {
                Dock = DockStyle.Fill
            };



            var entry = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Входит"
            };


            var output = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Выходит"
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
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            table.Dock = DockStyle.Fill;

            table.Controls.Add(title, 0, 0);
            table.Controls.Add(labeltext, 0, 1);
            table.Controls.Add(field, 0, 2);
            table.Controls.Add(entry, 0, 3);
            table.Controls.Add(output, 0, 4);
            table.Controls.Add(back, 0, 5);
            Controls.Add(table);

            //entry.Click += new EventHandler(this.Entry_Click);
            //output.Click += new EventHandler(this.Output_Click);
            back.Click += new EventHandler(this.Back_Click);
        }

        //private void Entry_Click(object sender, EventArgs e)
        //{
        //    if (dictUK.ContainsValue(field.Text) == true)
        //    {
        //        MessageBox.Show("Человек с идентификатором " + field.Text + " зашел на территорию");
        //        using (System.IO.StreamWriter file =
        //   new System.IO.StreamWriter("journal.txt", true))
        //        {
        //            file.WriteLine("Человек с идентификатором " + field.Text + " зашел на территорию");
        //        }
        //    }
        //}

        //private void Output_Click(object sender, EventArgs e)
        //{
        //    if (dictUK.ContainsValue(field.Text) == true)
        //    {
        //        MessageBox.Show("Человек с идентификатором " + field.Text + " вышел за территорию");
        //        using (System.IO.StreamWriter file =
        //   new System.IO.StreamWriter(@"C:\GUI\journal.txt", true))
        //        {
        //            file.WriteLine("Человек с идентификатором " + field.Text + " вышел за территорию");
        //        }
        //    }
        //}

        private void Back_Click(object sender, EventArgs e)
        {
            Form Start = new Start();
            Start.Show();
            this.Hide();
        }
    }
}
