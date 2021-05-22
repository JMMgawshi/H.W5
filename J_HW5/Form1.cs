using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.lib;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseOperations.getAttendance();
            getCourses(new DataTable());
            getRooms(new DataTable());
            getTeachers(new DataTable());
        }

        private void getCourses(DataTable table)
            {
            table.Columns.Add("course_id", typeof(string));            table.Columns.Add("course_name", typeof(string));            comboBox3.ValueMember = "course_id";            comboBox3.DisplayMember = "course_name";            comboBox3.DataSource = DatabaseOperations.getCourses();
            }

        private void getRooms(DataTable table)
            {
            table.Columns.Add("room_id", typeof(string));            table.Columns.Add("room_name", typeof(string));            comboBox1.ValueMember = "room_id";            comboBox1.DisplayMember = "room_name";            comboBox1.DataSource = DatabaseOperations.getRooms();
            }

        private void getTeachers(DataTable table)
            {
            table.Columns.Add("teacher_id", typeof(string));            table.Columns.Add("teacher_name", typeof(string));            comboBox2.ValueMember = "teacher_id";            comboBox2.DisplayMember = "teacher_name";            comboBox2.DataSource = DatabaseOperations.getTeachers();
            }

private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
