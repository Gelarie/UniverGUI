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
            var title = new Label();
            title.Location = new Point(0, 0);
            title.Size = new Size(ClientSize.Width, 35);
            title.Text = "Деканат";
            Controls.Add(title);

            var labeltext = new Label();
            labeltext.Location = new Point(0, title.Bottom);
            labeltext.Size = title.Size;
            labeltext.Text = "Выберите документ, который хотите сделать";
            Controls.Add(labeltext);

            var pass = new Button();
            pass.Location = new Point(0, labeltext.Bottom);
            pass.Size = title.Size;
            pass.Text = "Пропуск";
            pass.Click += (sender, args) =>
            {
                Form PassForm = new PassForm();
                PassForm.Show();
                this.Hide();
            };
            Controls.Add(pass);

            var card = new Button();
            card.Location = new Point(0, pass.Bottom);
            card.Size = title.Size;
            card.Text = "Студенческий билет";
            card.Click += (sender, args) =>
            {
                Form CardForm = new CardForm();
                CardForm.Show();
                this.Hide();
            };
            Controls.Add(card);

            var temppass = new Button();
            temppass.Location = new Point(0, card.Bottom);
            temppass.Size = title.Size;
            temppass.Text = "Временный пропуск";
            temppass.Click += (sender, args) =>
            {
                Form TemppassForm = new TemppassForm();
                TemppassForm.Show();
                this.Hide();
            };
            Controls.Add(temppass);

            var back = new Button();
            back.Location = new Point(0, temppass.Bottom);
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
