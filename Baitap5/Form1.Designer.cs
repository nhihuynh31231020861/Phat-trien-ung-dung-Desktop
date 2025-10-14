namespace Baitap5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupChon;
        private System.Windows.Forms.RadioButton rdbUSCLN;
        private System.Windows.Forms.RadioButton rdbBSCNN;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblA = new Label();
            lblB = new Label();
            lblKetQua = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            groupChon = new GroupBox();
            rdbBSCNN = new RadioButton();
            rdbUSCLN = new RadioButton();
            btnTim = new Button();
            btnBoQua = new Button();
            btnThoat = new Button();
            groupChon.SuspendLayout();
            SuspendLayout();
            lblA.AutoSize = true;
            lblA.Location = new Point(30, 30);
            lblA.Name = "lblA";
            lblA.Size = new Size(22, 20);
            lblA.TabIndex = 0;
            lblA.Text = "A:";
            lblB.AutoSize = true;
            lblB.Location = new Point(30, 70);
            lblB.Name = "lblB";
            lblB.Size = new Size(21, 20);
            lblB.TabIndex = 1;
            lblB.Text = "B:";
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(30, 120);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 5;
            lblKetQua.Text = "Kết quả";
            txtA.Location = new Point(70, 27);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 27);
            txtA.TabIndex = 2;
            txtB.Location = new Point(70, 67);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 27);
            txtB.TabIndex = 3;
            txtKetQua.Location = new Point(90, 117);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(150, 27);
            txtKetQua.TabIndex = 6;
            groupChon.Controls.Add(rdbBSCNN);
            groupChon.Controls.Add(rdbUSCLN);
            groupChon.Location = new Point(250, 20);
            groupChon.Name = "groupChon";
            groupChon.Size = new Size(120, 80);
            groupChon.TabIndex = 4;
            groupChon.TabStop = false;
            groupChon.Text = "Chọn tìm";
            rdbBSCNN.AutoSize = true;
            rdbBSCNN.Location = new Point(15, 50);
            rdbBSCNN.Name = "rdbBSCNN";
            rdbBSCNN.Size = new Size(78, 24);
            rdbBSCNN.TabIndex = 0;
            rdbBSCNN.Text = "BSCNN";
            rdbUSCLN.AutoSize = true;
            rdbUSCLN.Location = new Point(15, 25);
            rdbUSCLN.Name = "rdbUSCLN";
            rdbUSCLN.Size = new Size(75, 24);
            rdbUSCLN.TabIndex = 1;
            rdbUSCLN.Text = "USCLN";
            btnTim.Location = new Point(50, 160);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnBoQua.Location = new Point(150, 160);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(80, 30);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnThoat.Location = new Point(250, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 30);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            ClientSize = new Size(400, 220);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(groupChon);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnTim);
            Controls.Add(btnBoQua);
            Controls.Add(btnThoat);
            Name = "Form1";
            Text = "Tìm USCLN và BSCNN của A và B";
            groupChon.ResumeLayout(false);
            groupChon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
