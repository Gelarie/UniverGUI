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
            var title = new Label();
            title.Location = new Point(0, 0);
            title.Size = new Size(ClientSize.Width, 35);
            title.Text = "Охрана";
            Controls.Add(title);

            var labeltext = new Label();
            labeltext.Location = new Point(0, title.Bottom);
            labeltext.Size = title.Size;
            labeltext.Text = "Введите идентификатор";
            Controls.Add(labeltext);

            var field = new TextBox();
            field.Location = new Point(0, labeltext.Bottom);
            field.Size = title.Size;
            Controls.Add(field);


            var entry = new Button();
            entry.Location = new Point(0, field.Bottom);
            entry.Size = title.Size;
            entry.Text = "Входит";
            entry.Click += (sender, args) =>
            {
                MessageBox.Show("Сделано");
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter("journal.txt", true))
                {
                    file.WriteLine("Человек с идентификатором " + field.Text + " зашел на территорию");
                }
            };
            Controls.Add(entry);
            

            var output = new Button();
            output.Location = new Point(0, entry.Bottom);
            output.Size = title.Size;
            output.Text = "Выходит";
            output.Click += (sender, args) =>
            {
                MessageBox.Show("Сделано");
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"C:\GUI\journal.txt", true))
                {
                    file.WriteLine("Человек с идентификатором " + field.Text + " вышел за территорию");
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
