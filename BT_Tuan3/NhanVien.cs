using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3
{
    public partial class NhanVien : Form
    {
        DataTable dtNhanVien;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dtNhanVien = new DataTable();
            dtNhanVien.Columns.Add("Tên nhân viên");
            dtNhanVien.Columns.Add("Chức vụ");
            dtNhanVien.Columns.Add("Lương");
            dgvNhanVien.DataSource = dtNhanVien;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            dtNhanVien.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Thêm nhân viên thành công!");
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            int index = dgvNhanVien.CurrentRow.Index;
           
            dtNhanVien.Rows[index]["Tên nhân viên"] = textBox1.Text;
            dtNhanVien.Rows[index]["Chức vụ"] = textBox2.Text;
            dtNhanVien.Rows[index]["Lương"] = textBox3.Text;

            MessageBox.Show("Sửa thông tin thành công!");
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            int index = dgvNhanVien.CurrentRow.Index;
            dtNhanVien.Rows.RemoveAt(index);
            MessageBox.Show("Xóa nhân viên thành công!");
            LamMoi();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                textBox1.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        
    }
}
