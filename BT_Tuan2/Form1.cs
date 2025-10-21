﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Tuan2
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
            private void btnLuu_Click(object sender, EventArgs e)
            {
                dataGridView1.Rows.Add(txtTen.Text, cmbLoai.Text, numSoLuong.Value);
            }

            private void btnLamMoi_Click(object sender, EventArgs e)
            {
                txtTen.Clear();
                cmbLoai.SelectedIndex = -1;
                numSoLuong.Value = 0;
            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
