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
            labelText = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Куда вы хотите обратиться?"
            };

            security = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Охрана"
            };

            waggon = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Вахтер"
            };

            deanery = new Button()
            {
                Dock = DockStyle.Fill,
                Text = "Деканат"
            };

            var table = new TableLayoutPanel();

            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            table.Dock = DockStyle.Fill;

            table.Controls.Add(labelText, 0, 0);
            table.Controls.Add(security, 0, 1);
            table.Controls.Add(waggon, 0, 2);
            table.Controls.Add(deanery, 0, 3);
            Controls.Add(table);

            security.Click += new EventHandler(this.Security_Click);
            waggon.Click += new EventHandler(this.Waggon_Click);
            deanery.Click += new EventHandler(this.Deanery_Click);
        }
        private void Security_Click(object sender, EventArgs e)
        {
            Form SecurityForm = new SecurityForm();
            SecurityForm.Show();
            this.Hide();
        }

        private void Waggon_Click(object sender, EventArgs e)
        {
            Form WaggonForm = new WaggonForm();
            WaggonForm.Show();
            this.Hide();
        }

        private void Deanery_Click(object sender, EventArgs e)
        {
            Form DeaneryForm = new DeaneryForm();
            DeaneryForm.Show();
            this.Hide();
        }
   }
}

