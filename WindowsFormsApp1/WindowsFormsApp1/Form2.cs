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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string layMauSac()
        {
            if (rdbDen.Checked) return "Đen";

            if (rdbMauKhac.Checked) return "Màu khác";

            else return "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaHD", "Mã hợp đồng");
            dataGridView1.Columns.Add("TenKH", "Tên khách hàng");
            dataGridView1.Columns.Add("NgayBan", "Ngày bán");
            dataGridView1.Columns.Add("TenDT", "Tên điện thoại");
            dataGridView1.Columns.Add("MauSac", "Màu sắc");
            dataGridView1.Columns.Add("DonGia", "Đơn giá");
            dataGridView1.Columns.Add("SoLuong", "Số lượng");
            dataGridView1.Columns.Add("ThanhTien", "Thành tiền");

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtbMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbTenDT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                string mauSac = dataGridView1.Rows[e.RowIndex].Cells[]

                if
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
