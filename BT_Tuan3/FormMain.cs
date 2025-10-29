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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham f = new SanPham();
            f.MdiParent = this;
            f.Show();
            toolStripStatusLabelForm.Text = "Form hiện tại: Sản phẩm";
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            f.MdiParent = this;
            f.Show();
            toolStripStatusLabelForm.Text = "Form hiện tại: Nhân viên";
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.MdiParent = this;
            f.Show();
            toolStripStatusLabelForm.Text = "Form hiện tại: Hoá đơn";
        }
    }
}
