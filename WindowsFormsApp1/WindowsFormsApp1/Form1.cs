using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string layGioiTinh()
        {
            if (rbtNam.Checked)
            {
                return "Nam";
            }

            if (rbtNu.Checked)
            {
                return "Nữ";
            }

            else return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaSV", "Mã sinh viên");
            dataGridView1.Columns.Add("HoTen", "Họ tên");
            dataGridView1.Columns.Add("NoiSinh", "Nơi sinh");
            dataGridView1.Columns.Add("NgaySinh", "Ngày sinh");
            dataGridView1.Columns.Add("GioiTinh", "Giới tính");

            dataGridView1.AllowUserToAddRows = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lbNoiSinh_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void rbtNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtNu_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtbMaSV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbNoiSinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string gt = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (gt == "Nam")
                {
                    rbtNam.Checked = true;
                }

                else rbtNu.Checked = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                txtbMaSV.Text,
                txtbHoTen.Text,
                txtbNoiSinh.Text,
                dateTimePicker1.Value.ToShortDateString(),
                layGioiTinh()
                );
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = txtbMaSV.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtbHoTen.Text;
                dataGridView1.CurrentRow.Cells[2].Value = txtbNoiSinh.Text;
                dataGridView1.CurrentRow.Cells[3].Value = dateTimePicker1.Value.ToShortDateString();
                dataGridView1.CurrentRow.Cells[4].Value = layGioiTinh();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(
                    dataGridView1.CurrentRow.Index
                    );
            }

            else MessageBox.Show("Không có bất kỳ hàng nào!");
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.Show();
        }
    }
}