namespace Baitap4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnDel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSo1 = new Label();
            lblSo2 = new Label();
            lblKetQua = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnDel = new Button();
            SuspendLayout();
            lblSo1.AutoSize = true;
            lblSo1.Location = new Point(30, 30);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(85, 20);
            lblSo1.TabIndex = 0;
            lblSo1.Text = "Số thứ nhất";
            lblSo2.AutoSize = true;
            lblSo2.Location = new Point(30, 70);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(76, 20);
            lblSo2.TabIndex = 1;
            lblSo2.Text = "Số thứ hai";
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(30, 160);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 2;
            lblKetQua.Text = "Kết quả";
            txtSo1.Location = new Point(120, 27);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(180, 27);
            txtSo1.TabIndex = 3;
            txtSo1.TextChanged += txtSo1_TextChanged;
            txtSo2.Location = new Point(120, 67);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(180, 27);
            txtSo2.TabIndex = 4;
            txtKetQua.Location = new Point(120, 157);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(180, 27);
            txtKetQua.TabIndex = 5;
            btnCong.Location = new Point(30, 110);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(40, 30);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnTru.Location = new Point(80, 110);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(40, 30);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnNhan.Location = new Point(130, 110);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(40, 30);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnChia.Location = new Point(180, 110);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(40, 30);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnDel.Location = new Point(240, 110);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(60, 30);
            btnDel.TabIndex = 10;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            ClientSize = new Size(340, 210);
            Controls.Add(lblSo1);
            Controls.Add(lblSo2);
            Controls.Add(lblKetQua);
            Controls.Add(txtSo1);
            Controls.Add(txtSo2);
            Controls.Add(txtKetQua);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnDel);
            Name = "Form1";
            Text = "Máy tính bỏ túi";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
