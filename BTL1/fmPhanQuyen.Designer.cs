namespace BTL1
{
    partial class fmPhanQuyen
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
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSeeList = new DevExpress.XtraEditors.SimpleButton();
            this.btnRepair = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Location = new System.Drawing.Point(44, 113);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.Size = new System.Drawing.Size(763, 400);
            this.dgvPhanQuyen.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSeeList);
            this.panelControl1.Controls.Add(this.btnRepair);
            this.panelControl1.Location = new System.Drawing.Point(44, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(245, 61);
            this.panelControl1.TabIndex = 5;
            // 
            // btnSeeList
            // 
            this.btnSeeList.Location = new System.Drawing.Point(19, 10);
            this.btnSeeList.Name = "btnSeeList";
            this.btnSeeList.Size = new System.Drawing.Size(81, 46);
            this.btnSeeList.TabIndex = 3;
            this.btnSeeList.Text = "Xem Danh Sách";
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(138, 10);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(81, 46);
            this.btnRepair.TabIndex = 2;
            this.btnRepair.Text = "Sửa";
            // 
            // fmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 565);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Name = "fmPhanQuyen";
            this.Text = "fmPhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSeeList;
        private DevExpress.XtraEditors.SimpleButton btnRepair;
    }
}