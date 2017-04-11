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
    public partial class Addition : Form
    {
        public Addition()
        {
            Dictionary<int, string> dictCRK = new Dictionary<int, string>();
            dictCRK.Add(1, "132");
            dictCRK.Add(2, "A-17");
            dictCRK.Add(3, "222");
            //InitializeComponent();
            var title = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Добавление ключ-преподаватель"
            };

            var labelnumber = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Введите номер аудитории"
            };

            Controls.Add(title);
            Controls.Add(labelnumber);

            var fieldnumber = new TextBox()
            {
                Dock = DockStyle.Fill
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

            var add = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Добавить"
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
            table.Controls.Add(labelnumber, 0, 1);
            table.Controls.Add(fieldnumber, 0, 2);
            table.Controls.Add(labeltext, 0, 3);
            table.Controls.Add(fieldtext, 0, 4);

            table.Controls.Add(add, 0, 5);
            Controls.Add(table);

            //add.Click += new EventHandler(this.Add_Click);
        }

        //private void Back_Click(object sender, EventArgs e)
        //{
        //    dictCRK.Add(Convert.ToInt32(fieldnumber.Text), fieldtext.Text);
        //    MessageBox.Show("Добавлено");

        
    }
}
