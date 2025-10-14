namespace Baitap3
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNoiDung = new TextBox();
            btnHienThi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            txtNoiDung.Location = new Point(40, 50);
            txtNoiDung.Margin = new Padding(3, 4, 3, 4);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(300, 27);
            txtNoiDung.TabIndex = 0;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            btnHienThi.Location = new Point(40, 112);
            btnHienThi.Margin = new Padding(3, 4, 3, 4);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(120, 44);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnThoat.Location = new Point(220, 112);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 44);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 225);
            Controls.Add(txtNoiDung);
            Controls.Add(btnHienThi);
            Controls.Add(btnThoat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Sử dụng các sự kiện thông dụng";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}