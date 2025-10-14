using System;
using System.Windows.Forms;

namespace Baitap3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            btnHienThi.Click += btnHienThi_Click;
            btnThoat.Click += btnThoat_Click;
            this.KeyPreview = true;
            this.KeyDown += Form3_KeyDown;
            this.MouseClick += Form3_MouseClick;
            this.Load += Form3_Load;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn mở ứng dụng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string noiDung = txtNoiDung.Text;
            MessageBox.Show(noiDung, "Nội dung TextBox");
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                txtNoiDung.Text = "Xin chào Khoa CNTTKD";
            }
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Bạn vừa nhấp chuột phải!");
            else if (e.Button == MouseButtons.Left)
                MessageBox.Show("Bạn vừa nhấp chuột trái!");
            else if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Bạn vừa nhấp chuột giữa!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show(
                "Bạn có muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}