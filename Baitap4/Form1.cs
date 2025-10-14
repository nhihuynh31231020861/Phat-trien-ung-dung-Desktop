using System;
using System.Windows.Forms;

namespace Baitap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            btnCong.Click += btnCong_Click;
            btnTru.Click += btnTru_Click;
            btnNhan.Click += btnNhan_Click;
            btnChia.Click += btnChia_Click;
            btnDel.Click += btnDel_Click;
            txtSo1.KeyPress += txtSo_KeyPress;
            txtSo2.KeyPress += txtSo_KeyPress;
        }
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
                txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
                txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
                txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
            {
                if (b == 0)
                    MessageBox.Show("Không th? chia cho 0!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txtKetQua.Text = (a / b).ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
        }

        private bool TryGetValues(out double a, out double b)
        {
            bool a1 = double.TryParse(txtSo1.Text, out a);
            bool a2 = double.TryParse(txtSo2.Text, out b);
            if (!a1 || !a2)
            {
                MessageBox.Show("Vui lòng nh?p ?úng ??nh d?ng s?!", "L?i nh?p s?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}