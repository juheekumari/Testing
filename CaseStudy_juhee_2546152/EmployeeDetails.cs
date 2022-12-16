using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaseStudy_juhee_2546152
{
    public partial class EmployeeDetails : Form
    {
        public string  accessToken = ConfigurationManager.AppSettings["accessToken"];
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            GetAllEmployee();
        }

        /// <summary>
        /// get all  employee by consuming rest pi
        /// </summary>
        public void GetAllEmployee()
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("https://gorest.co.in/public/");
                    HttpResponseMessage response = client.GetAsync("v2/users").Result;
                    var emp = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                    grdEmployee.DataSource = emp;

                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

      
        /// <summary>
        /// search employee by his ID by consuming Get rest API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnserachby_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                    client.BaseAddress = new Uri("https://gorest.co.in/public/");
                    HttpResponseMessage response = client.GetAsync("v2/users/" + txtSearch.Text).Result;

                    Employee emp = response.Content.ReadAsAsync<Employee>().Result;
                    List<Employee> emplist = new List<Employee>();
                    emplist.Add(emp);
                    grdEmployee.DataSource = emplist;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        /// <summary>
        /// delete employee by his ID by consuming rest API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                    client.BaseAddress = new Uri("https://gorest.co.in/public/");
                    var response = client.DeleteAsync("v2/users/" + txtSearch.Text).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(txtSearch.Text + " " + "deleted successfully");
                        GetAllEmployee();
                    }
                    else
                        MessageBox.Show("error while deleting");
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        /// <summary>
        /// insert  new record by consuming rest api
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Isvalid())
                {
                    using (var client = new HttpClient())
                    {
                        Employee emp = new Employee() { name = txtName.Text, email = txtEmail.Text, gender = txtGender.Text, status = txtStatus.Text };//               
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                        client.BaseAddress = new Uri("https://gorest.co.in/public/");
                        HttpResponseMessage response = client.PostAsJsonAsync("v2/users/", emp).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("record inserted successfully");
                            GetAllEmployee();
                            var str = response.Content;
                        }

                        else
                        {
                            MessageBox.Show("Record not inserted");
                        }
                    }

                }
               
            }
            catch(Exception ex)
            {
                throw ;
            }

            finally
            {
                ClearTextValue();
            }
        }
        /// <summary>
        /// clear the textbox value after insert
        /// </summary>
        private void ClearTextValue()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtStatus.Text = "";
        }

        /// <summary>
        /// check whether all mandatory field has entered or not
        /// </summary>
        /// <returns></returns>
        public bool Isvalid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtGender.Text == string.Empty)
            {
                MessageBox.Show("Gender is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtStatus.Text == string.Empty)
            {
                MessageBox.Show("Status is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}
