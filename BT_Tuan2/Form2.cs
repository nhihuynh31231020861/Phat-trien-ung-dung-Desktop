using System.Windows.Forms;

namespace BT_Tuan2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                errorProvider1.SetError(txtUsername, "Vui lòng nhập Username!");
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                errorProvider1.SetError(txtPassword, "Vui lòng nhập Password!");

            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }

    }

}
