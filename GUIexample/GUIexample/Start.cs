using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIexample
{
    public partial class Start : Form
    {
        private Label labelText;
        private Button security, waggon, deanery;


        public Start()
        {
            labelText = new Label();
            labelText.Location = new Point(0, 0);
            labelText.Size = new Size(ClientSize.Width, 35);
            labelText.Text = "Куда вы хотите обратиться?";
            Controls.Add(labelText);

            security = new Button();
            security.Location = new Point(0, labelText.Bottom);
            security.Size = labelText.Size;
            security.Text = "Охрана";
            security.Click += (sender, args) =>
            {
                Form SecurityForm = new SecurityForm();
                SecurityForm.Show();
                this.Hide();
            };
            Controls.Add(security);

            waggon = new Button();
            waggon.Location = new Point(0, security.Bottom);
            waggon.Size = labelText.Size;
            waggon.Text = "Вахтер";
            waggon.Click += (sender, args) =>
            {
                Form WaggonForm = new WaggonForm();
                WaggonForm.Show();
                this.Hide();
            };
            Controls.Add(waggon);


            deanery = new Button();
            deanery.Location = new Point(0, waggon.Bottom);
            deanery.Size = labelText.Size;
            deanery.Text = "Деканат";
            deanery.Click += (sender, args) =>
            {
                Form DeaneryForm = new DeaneryForm();
                DeaneryForm.Show();
                this.Hide();
            };
            Controls.Add(deanery);


        }
    }
}
