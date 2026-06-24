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

        private double tinhTien()
        {
            double thanhTien, giamGia = 0, thue, donGia, soLuong;
            donGia = Convert.ToDouble(txtbDonGia.Text);
            soLuong = (int)numericUpDown1.Value;

            if (rdbDen.Checked)
            {
                giamGia = 0.05 * (donGia * soLuong);
            }

            if (rdbMauKhac.Checked)
            {
                giamGia = 0;
            }

            thue = 0.1 * ((donGia * soLuong) - giamGia);

            thanhTien = (donGia * soLuong) - giamGia + thue;

            return thanhTien;
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
                string mauSac = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (mauSac == "Đen") rdbDen.Checked = true;
                if (mauSac == "Màu khác") rdbMauKhac.Checked = true;
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                txtbMaHD.Text,
                txtbTenKH.Text,
                dateTimePicker1.Value.ToShortDateString(),
                txtbTenDT.Text,
                layMauSac(),
                txtbDonGia.Text,
                numericUpDown1.Text,
                tinhTien()
                );
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }

            else MessageBox.Show("Không có hàng nào để xóa!!"); //t thcish thì thêm cái này thôi
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = txtbMaHD.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtbTenKH.Text;
                dataGridView1.CurrentRow.Cells[2].Value = dateTimePicker1.Value.ToShortDateString();
                dataGridView1.CurrentRow.Cells[3].Value = txtbTenDT.Text;
                dataGridView1.CurrentRow.Cells[4].Value = layMauSac();
                dataGridView1.CurrentRow.Cells[5].Value = txtbDonGia.Text;
                dataGridView1.CurrentRow.Cells[6].Value = numericUpDown1.Text;
                dataGridView1.CurrentRow.Cells[7].Value = tinhTien();

                /*txtbMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbTenDT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string mauSac = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (mauSac == "Đen") rdbDen.Checked = true;
                if (mauSac == "Màu khác") rdbMauKhac.Checked = true;*/
            }
        }
    }

}
