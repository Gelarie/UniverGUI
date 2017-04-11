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
    public partial class DeaneryForm : Form
    {
        public DeaneryForm()
        {
            //InitializeComponent();
            var title = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Деканат"
            };



            var labeltext = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Выберите документ, который хотите сделать"
            };
            var pass = new Button()
            {

                Dock = DockStyle.Fill,
                Text = "Пропуск"
            };
            var card = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Студенческий билет"
            };
            var temppass = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Временный пропуск"
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
            table.Controls.Add(pass, 0, 2);
            table.Controls.Add(card, 0, 3);
            table.Controls.Add(temppass, 0, 4);
            table.Controls.Add(back, 0, 5);
            Controls.Add(table);


            pass.Click += new EventHandler(this.Pass_Click);
            card.Click += new EventHandler(this.Card_Click);
            temppass.Click += new EventHandler(this.Temppass_Click);
            back.Click += new EventHandler(this.Back_Click);
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            Form PassForm = new PassForm();
            PassForm.Show();
            this.Hide();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Form CardForm = new CardForm();
            CardForm.Show();
            this.Hide();
        }

        private void Temppass_Click(object sender, EventArgs e)
        {
            Form TemppassForm = new TemppassForm();
            TemppassForm.Show();
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

