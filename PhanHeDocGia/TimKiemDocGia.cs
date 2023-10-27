using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHeDocGia
{
    public partial class frm_TimKiemDocGia : Form
    {
        public frm_TimKiemDocGia()
        {
            InitializeComponent();
        }

        private void frm_TimKiemDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet1.tbl_docgia' table. You can move, or remove it, as needed.
            this.tbl_docgiaTableAdapter.Fill(this.qL_THUVIENDataSet1.tbl_docgia);
            this.panel_GioiHan.Enabled = true;
            this.panel_THoiGian.Enabled = true;
            this.panel_Thongtindocgia.Enabled = true;
            this.panel_Thongtindocgia.Visible = false;
            this.panel_THoiGian.Visible = false;
            this.panel_GioiHan.Visible = false; 

        }

        private void btn_ThongTinDocGia_Click(object sender, EventArgs e)
        {
            this.panel_THoiGian.Visible = false;
            this.panel_GioiHan.Visible = false;
            this.panel_Thongtindocgia.Visible = true;
            this.panel_Thongtindocgia.Location = new System.Drawing.Point(75, 90);
            this.panel_Thongtindocgia.BringToFront();
            //this.panel_body.Controls.Add(this.panel_Thongtindocgia);
        }

        private void btn_thoigian_Click(object sender, EventArgs e)
        {
            this.panel_Thongtindocgia.Visible = false;
            this.panel_GioiHan.Visible = false;
            this.panel_THoiGian.Visible = true;
            this.panel_THoiGian.Location = new Point(75, 90);
            this.panel_THoiGian.BringToFront();
            //this.panel_Thongtindocgia.Controls.Add(this.panel_THoiGian);
        }

        private void btn_GioiHan_Click(object sender, EventArgs e)
        {
            this.panel_THoiGian.Visible = false;
            this.panel_Thongtindocgia.Visible = false;
            this.panel_GioiHan.Visible = true;
            this.panel_GioiHan.Location = new System.Drawing.Point(75, 90);
            this.panel_GioiHan.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
