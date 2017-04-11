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
    public partial class WaggonForm : Form
    {

        public WaggonForm()
        {
            ////Dictionary<int, string> dictCRK = new Dictionary<int, string>();
            ////dictCRK.Add(1, "132");
            ////dictCRK.Add(2, "A-17");
            ////dictCRK.Add(3, "222");

            //InitializeComponent();

            var title = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Вахтер"
            };

            var labeltext = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Введите идентификатор"
            };

            var fieldtext = new TextBox()
            {
                Dock = DockStyle.Fill
            };

            var labelnumber = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Введите номер аудитории"
            };

            var fieldnumber = new TextBox()
            {
                Dock = DockStyle.Fill
            };

            var entry = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Выдал"
            };

            var output = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Получил"
            };

            var addition = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Добавление новой пары ключ-преподаватель"
            };

            var back = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Назад"
            };

            var table = new TableLayoutPanel();

            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            table.Dock = DockStyle.Fill;

            table.Controls.Add(title, 0, 0);
            table.Controls.Add(labeltext, 0, 1);
            table.Controls.Add(fieldtext, 0, 2);
            table.Controls.Add(labelnumber, 0, 3);
            table.Controls.Add(fieldnumber, 0, 4);
            table.Controls.Add(entry, 0, 5);
            table.Controls.Add(output, 0, 6);
            table.Controls.Add(addition, 0, 7);
            table.Controls.Add(back, 0, 8);
            Controls.Add(table);

            //entry.Click += new EventHandler(this.Entry_Click);
            //output.Click += new EventHandler(this.Output_Click);
            addition.Click += new EventHandler(this.Addition_Click);
            back.Click += new EventHandler(this.Back_Click);

        }

        //private void Entry_Click(object sender, EventArgs e)
        //{
        //    if ((dictCRK.ContainsKey(Convert.ToInt32(fieldtext.Text)) == true) && (dictCRK.ContainsValue(fieldnumber.Text)))
        //    {
        //        MessageBox.Show("ОК");
        //        using (System.IO.StreamWriter file =
        //   new System.IO.StreamWriter("key.txt", true))
        //        {
        //            file.WriteLine("Человек с идентификатором " + fieldtext.Text + " взял ключ от " + fieldnumber.Text);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Преподаватель с идентификатором " + fieldtext.Text + " не имеет доступа к " + fieldnumber.Text);
        //}

        //private void Output_Click(object sender, EventArgs e)
        //{
        //    if (dictCRK.ContainsValue(fieldnumber.Text) == true)
        //    {
        //        MessageBox.Show("ОК");
        //        using (System.IO.StreamWriter file =
        //   new System.IO.StreamWriter("key.txt", true))
        //        {
        //            file.WriteLine("Человек с идентификатором " + fieldtext.Text + " сдал ключ от " + fieldnumber.Text);
        //        }
        //    }
        //    else MessageBox.Show("Данный преподаватель не мог взять ключ от этой аудитории");
        //}
        private void Addition_Click(object sender, EventArgs e)
        {
            Form Addition = new Addition();
            Addition.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form Start = new Start();
            Start.Show();
            this.Hide();
        }
    }
}

