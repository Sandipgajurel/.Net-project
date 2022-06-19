using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int editRow;

        private void lblPriceSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNew f1 = new FormNew(); // Instantiate a Form3 object.
            f1.Show(); // Show Form
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formback form = new Formback();
            form.Show();
        }

        private void buttonCheckInForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(); // Instantiate a Form3 object.
            f4.Show(); // Show Form
        }

        private void lblWeekEnds_Click(object sender, EventArgs e)
        {

        }

        private void lblGroupOf_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtAgeGroup1.Text == "" || txtAgeGroup11.Text == "" || txtAgeGroup2.Text == "" || txtAgeGroup22.Text == ""
                     || cmbDuration.Text == ""
                     || cmbGroupOf.SelectedIndex == -1)
            {
                MessageBox.Show("please Enter Required Fields", "Empty Tex Field validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int childWeekdays, childWeekends, adultWeekdays, adultWeekends;
                String Group, Duration;


                try
                {
                    childWeekdays = Int32.Parse(txtAgeGroup1.Text);
                    childWeekends = Int32.Parse(txtAgeGroup11.Text);
                    adultWeekdays = Int32.Parse(txtAgeGroup2.Text);
                    adultWeekends = Int32.Parse(txtAgeGroup22.Text);
                    Group = (cmbGroupOf.Text);
                    Duration = (cmbDuration.Text);

                    TicketPrice t;
                    t = new TicketPrice();
                    t.childWeekdays = childWeekdays;
                    t.childWeekends = childWeekends;
                    t.adultWeekdays = adultWeekdays;
                    t.adultWeekends = adultWeekends;
                    t.Group = Group;
                    t.Duration = Duration;


                    string data = Utility.ReadPriceFromFile();
                    List<TicketPrice> lstPrice = new List<TicketPrice>();

                    if (data != null && data != "")
                    {
                        lstPrice = JsonConvert.DeserializeObject<List<TicketPrice>>(data);
                    }
                    lstPrice.Add(t);


                    string str1 = JsonConvert.SerializeObject(lstPrice);
                    Utility.WriteTicketPrice(str1);
                }
                catch (Exception)
                {

                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtAgeGroup1.Text = dataGridView1.Rows[e.RowIndex].Cells["childWeekdays"].FormattedValue.ToString();
                txtAgeGroup11.Text = dataGridView1.Rows[e.RowIndex].Cells["childWeekends"].FormattedValue.ToString();
                txtAgeGroup2.Text = dataGridView1.Rows[e.RowIndex].Cells["adultWeekdays"].FormattedValue.ToString();
                txtAgeGroup22.Text = dataGridView1.Rows[e.RowIndex].Cells["adultWeekends"].FormattedValue.ToString();
                cmbGroupOf.Text = dataGridView1.Rows[e.RowIndex].Cells["Group"].FormattedValue.ToString();
                cmbDuration.Text = dataGridView1.Rows[e.RowIndex].Cells["Duration"].FormattedValue.ToString();
                editRow = e.RowIndex;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string data = Utility.ReadPriceFromFile();
            List<TicketPrice> lstPrice = new List<TicketPrice>();
            if (data != null && data != "")
            {
                lstPrice = JsonConvert.DeserializeObject<List<TicketPrice>>(data);
            }
            this.dataGridView1.DataSource = lstPrice;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (txtAgeGroup1.Text == "" || txtAgeGroup11.Text == "" || txtAgeGroup2.Text == "" || txtAgeGroup22.Text == ""
                    || cmbDuration.Text == ""
                    || cmbGroupOf.SelectedIndex == -1)
            {
                MessageBox.Show("please Enter Required Fields", "Empty Tex Field validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int childWeekdays, childWeekends, adultWeekdays, adultWeekends;
                String Group, Duration;


                try
                {
                    childWeekdays = Int32.Parse(txtAgeGroup1.Text);
                    childWeekends = Int32.Parse(txtAgeGroup11.Text);
                    adultWeekdays = Int32.Parse(txtAgeGroup2.Text);
                    adultWeekends = Int32.Parse(txtAgeGroup22.Text);
                    Group = (cmbGroupOf.Text);
                    Duration = (cmbDuration.Text);

                    TicketPrice t;
                    t = new TicketPrice();
                    t.childWeekdays = childWeekdays;
                    t.childWeekends = childWeekends;
                    t.adultWeekdays = adultWeekdays;
                    t.adultWeekends = adultWeekends;
                    t.Group = Group;
                    t.Duration = Duration;

                    string data = Utility.ReadPriceFromFile();
                    List<TicketPrice> update = new List<TicketPrice>();
                    if (data != null && data != "")
                    {
                        update = JsonConvert.DeserializeObject<List<TicketPrice>>(data);
                    }

                    for (int i = 0; i < update.Count; i++)
                    {
                        if (editRow != -1)
                        {
                            update[editRow] = t;
                        }

                    }
                    string str1 = JsonConvert.SerializeObject(update);
                    Utility.WriteTicketPrice(str1);
                }


                catch (Exception)
                {

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAgeGroup1.Clear();
            txtAgeGroup11.Clear();
            txtAgeGroup2.Clear();
            txtAgeGroup22.Clear();
            cmbGroupOf.SelectedIndex = -1;
            cmbDuration.SelectedIndex = -1;
        }

        private void txtAgeGroup2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
