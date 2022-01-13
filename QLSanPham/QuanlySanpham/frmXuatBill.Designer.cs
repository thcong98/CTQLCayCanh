
namespace QuanlySanpham
{
    partial class frmXuatBill
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
            this.dgvXuatBill = new System.Windows.Forms.DataGridView();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXuatBill
            // 
            this.dgvXuatBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatBill.Location = new System.Drawing.Point(113, 60);
            this.dgvXuatBill.Name = "dgvXuatBill";
            this.dgvXuatBill.Size = new System.Drawing.Size(534, 184);
            this.dgvXuatBill.TabIndex = 0;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(513, 361);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(101, 25);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "Thời gian";
            this.lblThoiGian.Click += new System.EventHandler(this.lblThoiGian_Click);
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTongThanhTien.Location = new System.Drawing.Point(53, 308);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(298, 29);
            this.lblTongThanhTien.TabIndex = 1;
            this.lblTongThanhTien.Text = "Tiền cần phải thanh toán";
            this.lblTongThanhTien.Click += new System.EventHandler(this.lblTongThanhTien_Click);
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(272, 9);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(180, 24);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "BILL Khách hàng: ";
            this.lblBill.Click += new System.EventHandler(this.lblBill_Click);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(435, 9);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(162, 24);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian: ";
            // 
            // frmXuatBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.dgvXuatBill);
            this.Name = "frmXuatBill";
            this.Text = "frmXuatBill";
            this.Load += new System.EventHandler(this.frmXuatBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXuatBill;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label label1;
    }
}