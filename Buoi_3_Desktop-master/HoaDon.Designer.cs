namespace Buoi_3
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
         this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnIn = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
          this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
          
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(301, 370);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(125, 38);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lvItems
            // 
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(427, 64);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(361, 274);
            this.lvItems.TabIndex = 2;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(166, 88);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(230, 26);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(21, 94);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(123, 20);
            this.lblTenKH.TabIndex = 4;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(21, 300);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(62, 370);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(125, 38);
            this.btnThemSP.TabIndex = 6;
            this.btnThemSP.Text = "Thêm SP";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(538, 370);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(125, 38);
            this.btnLuuHoaDon.TabIndex = 7;
            this.btnLuuHoaDon.Text = "Lưu";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(21, 134);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(110, 20);
            this.lblTenSP.TabIndex = 8;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(166, 131);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(230, 26);
            this.txtTenSP.TabIndex = 9;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(24, 177);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(72, 20);
            this.lblSL.TabIndex = 10;
            this.lblSL.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(166, 173);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(230, 26);
            this.txtSL.TabIndex = 11;
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Location = new System.Drawing.Point(24, 221);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(64, 20);
            this.lblDG.TabIndex = 12;
            this.lblDG.Text = "Đơn giá";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(21, 262);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(84, 20);
            this.lblThanhTien.TabIndex = 13;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(166, 218);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(230, 26);
            this.txtDG.TabIndex = 14;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(166, 262);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(230, 26);
            this.txtTT.TabIndex = 15;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtDG);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblDG);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.btnIn);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtTT;
    }
}