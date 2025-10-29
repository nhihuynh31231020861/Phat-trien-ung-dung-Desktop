using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buoi_3
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            if (e.Node.Text == "Thực phẩm")
            {
                listView1.Items.Add(new ListViewItem(new[] { "SP01", "Gạo", "20000", "50" }));
                listView1.Items.Add(new ListViewItem(new[] { "SP02", "Thịt", "100000", "20" }));
            }
            if (e.Node.Text == "Đồ uống")
            {
                listView1.Items.Add(new ListViewItem(new[] { "DR01", "Cà phê", "20000", "50" }));
                listView1.Items.Add(new ListViewItem(new[] { "DR02", "Nước ép cam", "10000", "20" }));
            }
            if (e.Node.Text == "Gia vị")
            {
                listView1.Items.Add(new ListViewItem(new[] { "GV01", "Muối", "25000", "40" }));
                listView1.Items.Add(new ListViewItem(new[] { "GV02", "Đường", "30000", "30" }));
            }
            if (e.Node.Text == "Đồ gia dụng")
            {
                listView1.Items.Add(new ListViewItem(new[] { "GD01", "Bàn ủi", "200000", "40" }));
                listView1.Items.Add(new ListViewItem(new[] { "GV02", "Máy hút bụi", "500000", "45" }));
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Thực phẩm");
            treeView1.Nodes.Add("Đồ uống");
            treeView1.Nodes.Add("Gia vị");
            treeView1.Nodes.Add("Đồ gia dụng");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.Title = "Chọn file sản phẩm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                listView1.Items.Clear();

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        ListViewItem item = new ListViewItem(parts);
                        listView1.Items.Add(item);
                    }
                }

                MessageBox.Show("Import thành công!", "Thông báo");
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog1.Title = "Lưu danh sách sản phẩm";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string line = string.Join(",", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(s => s.Text));
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("Xuất file CSV thành công!", "Thông báo");
            }
        }

        private async void btnSimulateExport_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để export!");
                return;
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = listView1.Items.Count;
            progressBar1.Value = 0;

            // Ẩn nút khi đang export
            btnSimulateExport.Enabled = false;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                // Mô phỏng xử lý 1 sản phẩm (1 giây)
                await Task.Delay(1000);

                // Cập nhật tiến trình
                progressBar1.Value = i + 1;

                // Hiển thị phần trăm
                this.Text = $"Đang export... {(int)((i + 1) * 100 / listView1.Items.Count)}%";
            }

            // Sau khi hoàn tất
            btnSimulateExport.Enabled = true;
            this.Text = "Export hoàn tất!";
            MessageBox.Show("Xuất file CSV mô phỏng hoàn tất!", "Hoàn thành");
        }
    }
}
