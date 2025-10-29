using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Buoi_3
{
    public partial class HoaDon : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();

        public HoaDon()
        {
            InitializeComponent();

            // GÁN SỰ KIỆN IN NGAY KHI KHỞI TẠO
            printDocument1.PrintPage += printDocument1_PrintPage;

            // Khởi tạo cấu trúc ListView
            KhoiTaoListView();
        }

        private void KhoiTaoListView()
        {
            lvItems.View = View.Details;
            lvItems.Columns.Add("STT", 50);
            lvItems.Columns.Add("Tên sản phẩm", 150);
            lvItems.Columns.Add("Số lượng", 80);
            lvItems.Columns.Add("Đơn giá", 100);
            lvItems.Columns.Add("Thành tiền", 100);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.WindowState = FormWindowState.Maximized;
            preview.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 20;
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font normal = new Font("Arial", 10);

            e.Graphics.DrawString("CỬA HÀNG MINI - HÓA ĐƠN BÁN HÀNG", headerFont, Brushes.Black, 120, y);
            y += 40;
            e.Graphics.DrawString($"Khách hàng: {txtTenKH.Text}", normal, Brushes.Black, 20, y);
            y += 25;
            e.Graphics.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", normal, Brushes.Black, 20, y);
            y += 30;

            // Tiêu đề bảng
            e.Graphics.DrawString("STT", normal, Brushes.Black, 20, y);
            e.Graphics.DrawString("Tên sản phẩm", normal, Brushes.Black, 60, y);
            e.Graphics.DrawString("Số lượng", normal, Brushes.Black, 260, y);
            e.Graphics.DrawString("Đơn giá", normal, Brushes.Black, 340, y);
            e.Graphics.DrawString("Thành tiền", normal, Brushes.Black, 440, y);
            y += 25;

            // Danh sách sản phẩm
            int stt = 1;
            decimal total = 0;
            foreach (ListViewItem it in lvItems.Items)
            {
                string tenSp = it.SubItems[1].Text;
                int soLuong = int.Parse(it.SubItems[2].Text);
                decimal donGia = decimal.Parse(it.SubItems[3].Text);
                decimal thanhTien = soLuong * donGia * 1000;

                e.Graphics.DrawString(stt.ToString(), normal, Brushes.Black, 20, y);
                e.Graphics.DrawString(tenSp, normal, Brushes.Black, 60, y);
                e.Graphics.DrawString(soLuong.ToString(), normal, Brushes.Black, 260, y);
                e.Graphics.DrawString(donGia.ToString("N0"), normal, Brushes.Black, 340, y);
                e.Graphics.DrawString(thanhTien.ToString("N0"), normal, Brushes.Black, 440, y);

                total += thanhTien;
                y += 20;
                stt++;
            }

            y += 15;
            e.Graphics.DrawLine(Pens.Black, 20, y, 540, y);
            y += 15;

            e.Graphics.DrawString("Tổng cộng: " + total.ToString("N0") + " VND",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 320, y);
            y += 30;

            e.Graphics.DrawString("Cảm ơn quý khách! Hẹn gặp lại!", normal, Brushes.Black, 20, y);
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (ListViewItem item in lvItems.Items)
            {
                if (item.SubItems.Count > 4) // kiểm tra có đủ cột
                {
                    string text = item.SubItems[4].Text
                        .Replace(",", "")
                        .Replace("VNĐ", "")
                        .Replace("₫", "")
                        .Trim();

                    if (decimal.TryParse(text, out decimal gia))
                    {
                        tong += gia;
                    }
                }
            }

            tong *= 1000; // nếu muốn thêm 3 số 0

            lblTongTien.Text = tong.ToString("N0") + " VNĐ";
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text;
            int soLuong = int.Parse(txtSL.Text);
            decimal donGia = decimal.Parse(txtDG.Text);
            decimal thanhTien = soLuong * donGia;

            ListViewItem item = new ListViewItem((lvItems.Items.Count + 1).ToString());
            item.SubItems.Add(tenSP);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(donGia.ToString("N0"));
            item.SubItems.Add(thanhTien.ToString("N0"));
            lvItems.Items.Add(item);

            TinhTongTien();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text File|*.txt";
            saveDialog.Title = "Lưu hóa đơn";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                {
                    sw.WriteLine("HÓA ĐƠN BÁN HÀNG");
                    sw.WriteLine("Tên khách hàng: " + txtTenKH.Text);
                    sw.WriteLine("Ngày in: " + DateTime.Now);
                    sw.WriteLine("------------------------------------------");
                    foreach (ListViewItem item in lvItems.Items)
                    {
                        sw.WriteLine($"{item.SubItems[1].Text} | SL: {item.SubItems[2].Text} | Giá: {item.SubItems[3].Text} | Thành tiền: {item.SubItems[4].Text}");
                    }
                    sw.WriteLine("------------------------------------------");
                    sw.WriteLine("Tổng tiền: " + lblTongTien.Text);
                }

                MessageBox.Show("Lưu hóa đơn thành công!");
            }
        }
    }
}
