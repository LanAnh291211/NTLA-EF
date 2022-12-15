using NTLA.DTO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            LoadStudent();
        }
        void LoadStudent()
        {
            string student_Name = textBox1.Text;
           
            dataGridView1.DataSource = BLL.BLL.Instance.GetStudents(0);
        }
        void LoadCBBClass()
        {
            cbb_Class.Items.Add(new CBBItems
            {
                Name = "All",
                Value = 0
            });
            var classes = BLL.BLL.Instance.GetClasses();
            
            cbb_Class.SelectedIndex = 0;
        }
        private void cbb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

      

        private void btn_Sort_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
