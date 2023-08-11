
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Project4_GR3
{
    public partial class Form1 : Form
    {
        PhieuNhapBUS pnb =  new PhieuNhapBUS();
        LinhKienBUS lkb= new LinhKienBUS();
        PhieuNhapDTO pndto= new PhieuNhapDTO();
        LinhKienDTO lkdto = new LinhKienDTO();
        private int indexRow;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = pnb.ReadAll();
           
            foreach (Control control in pn_lk.Controls)
            {
                // Disable the control
                control.Enabled = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_maphieu.Text = row.Cells[0].Value.ToString();
            dtngaynhap.Text = row.Cells[1].Value.ToString();

            dataGridView2.DataSource = lkb.Readitem(lkdto);
        }
        #region phieunhap
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maphieu.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
       else

            {
                pndto.Maphieunhap = Convert.ToInt32(txt_maphieu.Text);
                pnb.Delete(pndto);
                MessageBox.Show("Đã xóa thành công");
                ClearTextBoxes();
                dataGridView1.DataSource = pnb.ReadAll();
                dataGridView2.DataSource = lkb.Readitem(lkdto);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtngaynhap.Text);
            //string holidayDateString = date.ToString("yyyy-MM-dd");

            pndto.Ngaynhap = date;
            ClearTextBoxes();
            pnb.Create(pndto);
            foreach (Control control in pn_lk.Controls)
            {

                control.Enabled = true;
            }
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (txt_maphieu.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập mã");
                txt_maphieu.Focus();    
            }
            else
            {
                lkdto.Maphieunhap = Convert.ToInt32(txt_maphieu.Text);
                dataGridView2.DataSource = lkb.Readitem(lkdto);
                foreach (Control control in pn_lk.Controls)
                {

                    control.Enabled = true;
                }
            }
            
        }
        #endregion
        private void ClearTextBoxes()
        {
           
            txt_maphieu.Text = "";
            dtngaynhap.Text = "";
            txt_maphieunhap.Text = " ";
            txt_malinhkien.Text = "";
            txt_tenlinhkien.Text = "";
            txt_soluong.Text = "";
        }
        #region linhkien

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            txt_maphieunhap.Text = row.Cells[0].Value.ToString();
            txt_malinhkien.Text = row.Cells[1].Value.ToString();
            txt_tenlinhkien.Text = row.Cells[2].Value.ToString();
            txt_soluong.Text = row.Cells[3].Value.ToString();
        }

        #endregion

        private void btn_themLK_Click(object sender, EventArgs e)
        {
            if(txt_maphieunhap.TextLength==0)
            {
                MessageBox.Show("Vui lòng nhập mã");
                txt_maphieunhap.Focus();
            }
                else if(txt_tenlinhkien.TextLength==0)
                {
                    MessageBox.Show("Vui lòng nhập Tên linh kiện");
                    txt_tenlinhkien.Focus();
                }
                    else if(txt_soluong.TextLength==0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng");
                        txt_soluong.Focus();
                    }
            else
            {
                lkdto.Maphieunhap = Convert.ToInt32(txt_maphieunhap.Text);
                lkdto.Tenlinhkien = txt_tenlinhkien.Text;
                lkdto.Soluong = Convert.ToInt32(txt_soluong.Text);
                lkb.Create(lkdto);
                ClearTextBoxes();
                dataGridView2.DataSource = lkb.Readitem(lkdto);
            }
            
        }
    }
}
