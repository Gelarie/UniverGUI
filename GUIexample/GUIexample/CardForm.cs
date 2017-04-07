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
    public partial class CardForm : Form
    {
        public CardForm()
        {
            //InitializeComponent();
            var title = new Label();
            title.Location = new Point(0, 0);
            title.Size = new Size(ClientSize.Width, 35);
            title.Text = "Студенческий билет";
            Controls.Add(title);

            var labeltext = new Label();
            labeltext.Location = new Point(0, title.Bottom);
            labeltext.Size = title.Size;
            labeltext.Text = "Введите фамилию";
            Controls.Add(labeltext);

            var lastname = new TextBox();
            lastname.Location = new Point(0, labeltext.Bottom);
            lastname.Size = title.Size;
            Controls.Add(lastname);

            var receipt = new Button();
            receipt.Location = new Point(0, lastname.Bottom);
            receipt.Size = title.Size;
            receipt.Text = "Получить";
            receipt.Click += (sender, args) =>
            {
                MessageBox.Show("ОК");
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter("pass.txt", true))
                {
                    file.WriteLine(lastname.Text + " получил " + title.Text);
                }
            };
            Controls.Add(receipt);

            var back = new Button();
            back.Location = new Point(0, receipt.Bottom);
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
