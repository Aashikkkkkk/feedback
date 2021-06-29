using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;



namespace Feedback_System
{
    public partial class AdminForm : Form
    {

        string cPath = "Criteria.txt";
        DataTable table = new DataTable();
        List<string> criteria = new List<string>();
        bool forCheck = false;


        public AdminForm()
        {
            InitializeComponent();
            BindChart();
            Report();
        }




        // it is for criteria.
        private void btnCriteria_Click(object sender, EventArgs e)
        {
            string check = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCriteria.Text).Trim();

            // check if the given value is empty  or repeated and if not, it saves in the files and display in the grid view. 
            if (string.IsNullOrEmpty(check))
            {
                MessageBox.Show("Please Type the Criteria");
            }
            else if (!(check.Equals("Food Quality") || check.Equals("Cleanliness") || check.Equals("Order Accuracy") || check.Equals("Restaurant Ambiance") || check.Equals("Staff Friendliness") || check.Equals("Value Of Money")))
            {
                MessageBox.Show("Error: Incorrect spelling Criteria.");
            }
            else if (criteria.Contains(check))
            {

                MessageBox.Show("This Criteria already exists: " + check);
            }
            else
            {
                AdminCriteria ac = new AdminCriteria();
                ac.Criteria = check;


                // to convert object to byte stream.
                ac.saveCriteria(ac, cPath);

                // to show in the gridview.
                List<AdminCriteria> listReview = ac.CriteriaList(cPath);

                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(AdminCriteria));
                DataRow row = table.NewRow();
                foreach (var item in listReview)
                {
                    foreach (PropertyDescriptor prop in properties) // criteria
                    {
                        string rowName = (string)prop.GetValue(item); // name of row


                        DataRow[] rowExist = table.Select("Criteria = '" + rowName + "'");
                        if (rowExist.Length == 0)
                        {
                            row["Criteria"] = (string)prop.GetValue(item);
                            table.Rows.Add(row);
                        }
                    }
                }

                GridAdmin.DataSource = table;
                GridAdmin.AutoResizeColumns();
                criteria.Add(check);
                txtCriteria.Text = "";
                forCheck = true;
            }

        }



        // it is to show the customer panel when clicked on submit button.
        private void adminBtn_Click_1(object sender, EventArgs e)
        {
            String criteria = txtCriteria.Text;
            if (forCheck == false)
            {
                MessageBox.Show("Error: no criteria added.");
            }
            else
            {
                this.Hide();
                Customer cs = new Customer(true);
                cs.Show();

            }
        }

        // it is to empty the files of rating and criteria when loading the admin panel and adding the constant column. 
        private void AdminForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Criteria", typeof(string));
            table.Columns.Add("Excellent", typeof(string));
            table.Columns.Add("Good", typeof(string));
            table.Columns.Add("Average", typeof(string));
            table.Columns.Add("Dissatisfied", typeof(string));

            // to empty the file when loading the admin form
            File.WriteAllText(cPath, string.Empty);
        }


        // to show Home when clicked .
        private void homeAdmin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        // to show Report when clicked.
        private void ReportAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r = new Report();
            r.Show();
        }

        // for binding data the chart
        private void BindChart()
        {
            CustomerReview cr = new CustomerReview();
            List<CustomerReview> customerReviews = cr.CustomerList();

            if (comChart.Text == "Food Quality")
            {
                var chartResult = customerReviews.GroupBy(x => x.Food_Quality)
                   .Select(l => new  // dynamic object

                   {
                       FoodQuality = l.First().Food_Quality,
                       count = l.Count()
                   }).ToList();

                foreach (var item in chartResult)
                {
                    chart1.Series["Customers"].Points.AddXY(item.FoodQuality.ToString(), item.count);
                }

                chart1.Titles.Add("Food Quality");

            }
            else if (comChart.Text == "Cleanliness")
            {
                var chartResult = customerReviews.GroupBy(x => x.Cleanliness)
                    .Select(l => new
                    {
                        Cleanliness = l.First().Cleanliness,
                        count = l.Count()
                    }).ToList();

                foreach (var item in chartResult)
                {
                    chart1.Series["Customers"].Points.AddXY(item.Cleanliness.ToString(), item.count);
                }

                chart1.Titles.Add("Cleanliness");
            }
            else if (comChart.Text == "Staff Friendliness")
            {
                var chartResult = customerReviews.GroupBy(x => x.Staff_Friendliness)
                    .Select(l => new
                    {
                        StaffFriendliness = l.First().Staff_Friendliness,
                        count = l.Count()
                    }).ToList();

                foreach (var item in chartResult)
                {
                    chart1.Series["Customers"].Points.AddXY(item.StaffFriendliness.ToString(), item.count);
                }

                chart1.Titles.Add("Staff Friendliness");

            }
            else if (comChart.Text == "Value Of Money")
            {
                var chartResult = customerReviews.GroupBy(x => x.Value_of_Money)
                    .Select(l => new
                    {
                        ValueOfMoney = l.First().Value_of_Money,
                        count = l.Count()
                    }).ToList();

                foreach (var item in chartResult)
                {
                    chart1.Series["Customers"].Points.AddXY(item.ValueOfMoney.ToString(), item.count);
                }

                chart1.Titles.Add("Value Of Money");

            }
            else if (comChart.Text == "Restaurant Ambiance")
            {
                var chartResult = customerReviews.GroupBy(x => x.Restaurant_Ambiance)
                    .Select(l => new
                    {
                        RestaurantAmbience = l.First().Restaurant_Ambiance,
                        count = l.Count()
                    }).ToList();

                foreach (var item in chartResult)
                {
                    chart1.Series["Customers"].Points.AddXY(item.RestaurantAmbience.ToString(), item.count);
                }

                chart1.Titles.Add("Restaurant Ambience");

            }
            else
            {
                var chartResult = customerReviews.GroupBy(x => x.Order_Accuracy)
                   .Select(l => new
                   {
                       OrderAccuracy = l.First().Order_Accuracy,
                       count = l.Count()
                   }).ToList();

                foreach (var item in chartResult)
                {
                    chart1.Series["Customers"].Points.AddXY(item.OrderAccuracy.ToString(), item.count);
                }

                chart1.Titles.Add("Order Accuracy");

            }
            chart1.ChartAreas[0].AxisX.Title = "Rating";


        }


        private void Report()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CRITERIA");
            dt.Columns.Add("TOTAL RATING");

            CustomerReview cr = new CustomerReview();
            List<CustomerReview> customerReviews = cr.CustomerList();
            if (customerReviews.Count != 0)
            {


                var result = customerReviews.GroupBy(x => x != null) // grouping with not null in order to add the ratings
                            .Select(l => new
                            {
                                Cleanliness = l.Sum(x => x.Cleanliness),
                                Food_Quality = l.Sum(x => x.Food_Quality),
                                Order_Accuracy = l.Sum(x => x.Order_Accuracy),
                                Restaurant_Ambiance = l.Sum(x => x.Restaurant_Ambiance),
                                Staff_Friendliness = l.Sum(x => x.Staff_Friendliness),
                                Value_of_Money = l.Sum(x => x.Value_of_Money)
                            }).ToList();


                DataRow rows = dt.NewRow();
                rows["CRITERIA"] = "Food QUALITY";
                rows["TOTAL RATING"] = result[0].Food_Quality;
                dt.Rows.Add(rows);

                rows = dt.NewRow();
                rows["CRITERIA"] = "CLEANLINESS";
                rows["TOTAL RATING"] = result[0].Cleanliness;
                dt.Rows.Add(rows);

                rows = dt.NewRow();
                rows["CRITERIA"] = "ORDER ACCURACY";
                rows["TOTAL RATING"] = result[0].Order_Accuracy;
                dt.Rows.Add(rows);

                rows = dt.NewRow();
                rows["CRITERIA"] = "RESTAURANT AMBIANCE";
                rows["TOTAL RATING"] = result[0].Restaurant_Ambiance;
                dt.Rows.Add(rows);

                rows = dt.NewRow();
                rows["CRITERIA"] = "STAFF FRIENDLINESS";
                rows["TOTAL RATING"] = result[0].Staff_Friendliness;
                dt.Rows.Add(rows);

                rows = dt.NewRow();
                rows["CRITERIA"] = "VALUE OF MONEY";
                rows["TOTAL RATING"] = result[0].Value_of_Money;
                dt.Rows.Add(rows);
                overAllReportGrid.DataSource = dt;
                overAllReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }




        private void txtCriteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void criteriaSearch_Click(object sender, EventArgs e)
        {
            if (comChart.SelectedIndex < 0)
            {
                MessageBox.Show("Error: Select the Criteria");
            }
            else
            {
                chart1.Series[0].Points.Clear(); // in order to display new chart.
                chart1.Titles.Clear();
                BindChart();
            }
        }
    }
}





