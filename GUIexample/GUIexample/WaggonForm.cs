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
            //InitializeComponent();
            var title = new Label();
            title.Location = new Point(0, 0);
            title.Size = new Size(ClientSize.Width, 35);
            title.Text = "Вахтер";
            Controls.Add(title);

            var labeltext = new Label();
            labeltext.Location = new Point(0, title.Bottom);
            labeltext.Size = title.Size;
            labeltext.Text = "Введите идентификатор";
            Controls.Add(labeltext);

            var fieldtext = new TextBox();
            fieldtext.Location = new Point(0, labeltext.Bottom);
            fieldtext.Size = title.Size;
            Controls.Add(fieldtext);

            var labelnumber = new Label();
            labelnumber.Location = new Point(0, fieldtext.Bottom);
            labelnumber.Size = title.Size;
            labelnumber.Text = "Введите номер аудитории";
            Controls.Add(labelnumber);

            var fieldnumber = new TextBox();
            fieldnumber.Location = new Point(0, labelnumber.Bottom);
            fieldnumber.Size = title.Size;
            Controls.Add(fieldnumber);

            var entry = new Button();
            entry.Location = new Point(0, fieldnumber.Bottom);
            entry.Size = title.Size;
            entry.Text = "Выдал";
            entry.Click += (sender, args) =>
            {
                MessageBox.Show("ОК");
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter("key.txt", true))
                {
                    file.WriteLine("Человек с идентификатором " + fieldtext.Text + " взял ключ от " + fieldnumber.Text);
                }
            };
            Controls.Add(entry);

            var output = new Button();
            output.Location = new Point(0, entry.Bottom);
            output.Size = title.Size;
            output.Text = "Получил";
            output.Click += (sender, args) =>
            {
                MessageBox.Show("ОК");
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter("key.txt", true))
                {
                    file.WriteLine("Человек с идентификатором " + fieldtext.Text + " сдал ключ от " + fieldnumber.Text);
                }
            };

            Controls.Add(output);

            var back = new Button();
            back.Location = new Point(0, output.Bottom);
            back.Size = title.Size;
            back.Text = "Назад";
            back.Click += (sender, args) =>
            {
                Form Start = new Start();
                Start.Show();
                this.Hide();
            };
            Controls.Add(back);
        }
    }
}
