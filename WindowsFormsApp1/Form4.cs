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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "" || txtAge.Text == "" || txtPhone.Text == "" || txtName.Text == ""
                    || txtInTime.Text == "" 
                    || cmbGroup.SelectedIndex == -1)
            {
                MessageBox.Show("please Fill required Fields", "Empty Field validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int id, Age;
                double Price;
                String Name, Phone, Group, Date, Duration, AgeGroup, InTime, EndTime;
               
                     id = Int32.Parse(txtId.Text);
                     Name = (txtName.Text);
                     Phone = (txtPhone.Text);
                     Date = (cmbDate.Text);
                     InTime = (txtInTime.Text);
                     EndTime = (txtEndTime.Text);
                     Duration = (cmbDuration.Text);
                     Price = double.Parse(txtPrice.Text);
                     Group = (cmbGroup.Text);
                     Age = Int32.Parse(txtAge.Text);
                     

                AgeGroup = "";
                if(Age>=5 && Age <= 12)
                {
                    AgeGroup = "5-12(child)";
                }
                else if (Age >= 13)
                {
                    AgeGroup = "Above12(Adult)";
                }


                zoo z;
                    z = new zoo();
                    z.Id = id;
                    z.Name = Name;
                    z.Phone = Phone;
                    z.Age = Age;
                    z.Group = Group;
                    z.AgeGroup = AgeGroup;
                    z.Date = Date;
                    z.InTime = InTime;
                    z.EndTime = EndTime;
                    z.Duration = Duration;
                    z.Price = Price;



                    string data = Utility.ReadFromFile();
                    List<zoo> lstzoo = new List<zoo>();
                    if (data != null && data != "")
                    {
                        lstzoo = JsonConvert.DeserializeObject<List<zoo>>(data);
                    }
                    lstzoo.Add(z);


                    string str = JsonConvert.SerializeObject(lstzoo);
                    Utility.WriteToText(str);
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAge.Text == "" || txtPhone.Text == "" || txtName.Text == ""
                    || txtInTime.Text == ""
                    || cmbGroup.SelectedIndex == -1)
            {
                MessageBox.Show("please Fill required Fields", "Empty Field validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id, Age;
                double Price;
                String Name, Phone, Group, Date, Duration, AgeGroup, InTime, EndTime;

                id = Int32.Parse(txtId.Text);
                Name = (txtName.Text);
                Phone = (txtPhone.Text);
                Date = (cmbDate.Text);
                InTime = (txtInTime.Text);
                EndTime = (txtEndTime.Text);
                Duration = (cmbDuration.Text);
                Price = double.Parse(txtPrice.Text);
                Age = Int32.Parse(txtAge.Text);
                Group = (cmbGroup.Text);

                AgeGroup = "";
                if (Age >= 5 && Age <= 12)
                {
                    AgeGroup = "5-12(child)";
                }
                else if (Age >= 13)
                {
                    AgeGroup = "Above12(Adult)";
                }


                zoo z;
                z = new zoo();
                z.Id = id;
                z.Name = Name;
                z.Phone = Phone;
                z.Age = Age;
                z.Group = Group;
                z.AgeGroup = AgeGroup;
                z.Date = Date;
                z.InTime = InTime;
                z.EndTime = EndTime;
                z.Duration = Duration;
                z.Price = Price;

                string data = Utility.ReadFromFile();
                List<zoo> edit = new List<zoo>();

                if (data != null && data != "")
                {
                    edit = JsonConvert.DeserializeObject<List<zoo>>(data);
                }


                for (int i = 0; i < edit.Count; i++)
                {

                    int index = edit.FindIndex(x => x.Id == id);
                    if (index != -1)
                    {
                        edit[index] = z;
                    }
                }

                string str = JsonConvert.SerializeObject(edit);
                Utility.WriteToText(str);
            
             
            }
            }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            //cmbDate.Clear();
            txtInTime.Clear();
            txtEndTime.Clear();
            cmbDuration.SelectedIndex = -1;
            txtPrice.Clear();
            txtPhone.Clear();
            cmbGroup.SelectedIndex = -1;
            comboBoxAgeGroup.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string data = Utility.ReadFromFile();
            List<zoo> lstzoo = new List<zoo>();
            if (data != null && data != "")
            {
                lstzoo = JsonConvert.DeserializeObject<List<zoo>>(data);
            }
            this.dataGridView1.DataSource = lstzoo;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                cmbGroup.Text = dataGridView1.Rows[e.RowIndex].Cells["Group"].FormattedValue.ToString();
                comboBoxAgeGroup.Text = dataGridView1.Rows[e.RowIndex].Cells["AgeGroup"].FormattedValue.ToString();
                cmbDate.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString();
                txtInTime.Text = dataGridView1.Rows[e.RowIndex].Cells["InTime"].FormattedValue.ToString();
                txtEndTime.Text = dataGridView1.Rows[e.RowIndex].Cells["EndTime"].FormattedValue.ToString();
                cmbDuration.Text = dataGridView1.Rows[e.RowIndex].Cells["Duration"].FormattedValue.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formback form = new Formback();
            form.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(); // Instantiate a Form3 object.
            f3.Show(); // Show Form
        }

        private void txtEndTime_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtInTime.Text != "" && txtEndTime.Text != "")
                {
                    String inTime = txtInTime.Text;
                    String endTime = txtEndTime.Text;
                    TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(inTime));

                    Console.Out.WriteLine(duration);
                    double timecase = duration.TotalHours;
                    Console.Out.WriteLine(timecase);

                    if (timecase <= 1 && timecase > 0)
                    {
                        cmbDuration.SelectedIndex = 0;
                    }

                    else if (timecase <= 2 && timecase > 1)
                    {
                        cmbDuration.SelectedIndex = 1;
                    }
                    else if (timecase <= 3 && timecase > 2)
                    {
                        cmbDuration.SelectedIndex = 2;
                    }
                    else if (timecase <= 4 && timecase > 3)
                    {
                        cmbDuration.SelectedIndex = 3;
                    }
                    else if (timecase > 4)
                    {
                        cmbDuration.SelectedIndex = 4;
                    }

                }
                else
                {
                    cmbDuration.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string data = Utility.ReadPriceFromFile();
                List<TicketPrice> lstticket = new List<TicketPrice>();
                if (data != null && data != "")
                {
                    lstticket = JsonConvert.DeserializeObject<List<TicketPrice>>(data);
                }

                string group = cmbGroup.Text;
                string duration = cmbDuration.Text;
                String days = cmbDate.Value.DayOfWeek.ToString();
                String Agegroup = "";
                int age = Int32.Parse(txtAge.Text);

                if (age < 5)
                {
                    Agegroup = "child<5";
                }
                else if (age >= 5 && age <= 12)
                {
                    Agegroup = "child";
                }
                else if (age >= 13)
                {

                    Agegroup = "adult";
                }

                for (var i = 0; i < lstticket.Count; i++)
                {
                    if (lstticket[i].Group == group && lstticket[i].Duration == duration)
                    {

                        
                        if (days != "Saturday")
                        {
                            if (Agegroup == "child<5")
                            {
                                txtPrice.Text = "0";
                            }
                            else if (Agegroup == "child")
                            {
                                txtPrice.Text = lstticket[i].childWeekdays.ToString();
                            }
                            else
                            {
                                if (Agegroup == "adult")
                                {
                                    txtPrice.Text = lstticket[i].adultWeekdays.ToString();
                                }
                            }
                        }
                        else
                        {


                            if (Agegroup == "child<5")
                            {
                                txtPrice.Text = "0";
                            }
                            else if (Agegroup == "child")
                            {

                                txtPrice.Text = lstticket[i].childWeekends.ToString();

                            }
                            else
                            {
                                if (Agegroup == "adult")
                                {
                                    txtPrice.Text = lstticket[i].adultWeekends.ToString();
                                }
                            }

                        }


                    }

                }
            }
            catch
            {

            }




        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAgeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
