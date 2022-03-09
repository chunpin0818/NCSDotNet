using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2___Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2019DataSet.Department' table. You can move, or remove it, as needed.
            SetDataInGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DateTime dt=DateTime.Now;
            Department dp = new Department();
            dp.DepartmentID = Convert.ToInt16(textBox1.Text);
            dp.Name = textBox2.Text.Trim();
            dp.GroupName = textBox3.Text.Trim();
            dp.ModifiedDate = dt;

            try
            {
                AdventureWorks2019Entities db = new AdventureWorks2019Entities();
                db.Departments.Add(dp);
                db.SaveChanges();
                SetDataInGridView();
                MessageBox.Show("Records are Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Saved \nReason:" + ex);
                SetDataInGridView();
            }
            
        }

        private void Display_Click(object sender, EventArgs e)
        {
            SetDataInGridView();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Department dp = new Department();
            short updated_ID = Convert.ToInt16(textBox1.Text);
            string Name = textBox2.Text.Trim();
            string GroupName = textBox3.Text.Trim();

            try
            {
                AdventureWorks2019Entities db = new AdventureWorks2019Entities();
                dp = db.Departments.Where(d => d.DepartmentID == updated_ID).First();
                dp.Name = Name;
                dp.GroupName = GroupName;
                dp.ModifiedDate = dt;
                db.SaveChanges();
                SetDataInGridView();
                MessageBox.Show("Records are Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Updated \nReason:" + ex);
                SetDataInGridView();
            }               
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Department dp = new Department();
            short deleted_ID = Convert.ToInt16(textBox1.Text);
            
            try
            {
                AdventureWorks2019Entities db = new AdventureWorks2019Entities();
                dp = db.Departments.Where(d => d.DepartmentID == deleted_ID).First();
                db.Departments.Remove(dp);
                db.SaveChanges();
                SetDataInGridView();
                MessageBox.Show("Records are Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Deleted \nReason:"+ex);
                SetDataInGridView();
            }
            
        }

        public void SetDataInGridView()
        {
            AdventureWorks2019Entities db = new AdventureWorks2019Entities();
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.DataSource = db.Departments.ToList<Department>();
        }

    }
}
