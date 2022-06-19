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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Formback : Form
    {
        public Formback()
        {
            InitializeComponent();
            loadChart1();
            loadChart2();
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            string data = Utility.ReadFromFile();
            List<zoo> lstzoo = Newtonsoft.Json.JsonConvert.DeserializeObject<List<zoo>>(data);

            Console.Out.WriteLine(data);


            List<zoo> groupdata = new List<zoo>();
            var groupData = lstzoo.GroupBy(n => n.AgeGroup)
               .Select(n => new
               {
                   Group = n.Key,
                   Count = n.Count()
               }).AsEnumerable()
    .Cast<dynamic>()
    .ToList<dynamic>();

            dataGridView1.DataSource = groupData;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            string data = Utility.ReadFromFile();
            List<zoo> lstzoo = JsonConvert.DeserializeObject<List<zoo>>(data);

            Console.Out.WriteLine(data);


            List<zoo> groupdata = new List<zoo>();
            var groupData = lstzoo.GroupBy(n => new { n.Date, n.Price })
               .Select(n => new
               {
                   Days = n.Key.Date,
                   Totalprice = n.Sum(s => (int)n.Key.Price),
                   TotalNumber = n.Count(),


               }).AsEnumerable()
    .Cast<dynamic>()
    .ToList<dynamic>();
            dataGridView2.DataSource = groupData;
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNew f1 = new FormNew();
            f1.Show(); // Show Form
        }

        private void Formback_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPriceSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(); 
            f3.Show(); // Show Form
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 f4 = new Form4(); 
            f4.Show(); // Show Form
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void loadChart1()
        {
            string data = Utility.ReadFromFile();
            List<zoo> lstzoo = Newtonsoft.Json.JsonConvert.DeserializeObject<List<zoo>>(data);

            List<zoo> groupdata = new List<zoo>();
            var groupData = lstzoo.GroupBy(n => n.AgeGroup)
               .Select(n => new
               {
                   Group = n.Key,
                   Count = n.Count()
               }).OrderBy(n => n.Group);
            chart1.Series[0].LegendText = "Daily Report Graph";
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].XValueMember = "Group";
            chart1.Series[0].YValueMembers = "Count";
            chart1.DataSource = groupData;

        }

         private void loadChart2()
         {
            string data = Utility.ReadFromFile();
            List<zoo> lstzoo = JsonConvert.DeserializeObject<List<zoo>>(data);
            
            //LINQ :
            var groupData = lstzoo.GroupBy(n => new { n.Date })
               .Select(a => new
               {
                   Days = a.Key.Date.ToString(),
                   price = a.Sum(c => c.Price),
                   TotalNumber = a.Count(),
               });
            chart2.Series[0].LegendText = "weekly Report";
            chart2.Series[0].ChartType = SeriesChartType.Column;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0].XValueMember = "Days";
            chart2.Series[0].YValueMembers = "Price";
            chart2.DataSource = groupData;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = Utility.ReadFromFile();
            List<zoo> lstzoo = JsonConvert.DeserializeObject<List<zoo>>(data);
            var query = lstzoo.GroupBy(p => new { p.Date })
                               .Select(s => new Sorting
                               {
                                   Days = s.Key.Date.ToString(),
                                   price = s.Sum(p => p.Price),
                                   TotalNumber = s.Count(),
                               }).ToList();



            List<Sorting> bubble;
            bubble = BubbleSort(query);
            dataGridView2.DataSource = bubble;
            chart2.DataSource = bubble;
            List<Sorting> BubbleSort(List<Sorting> list)
            {
                for (int i = list.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (list[j].price > list[j + 1].price)
                        {
                            double big = list[j].price;
                            list[j].price = list[j + 1].price;
                            list[j + 1].price = big;
                        }
                    }
                }
                return list;
            }
        }
    }
}
