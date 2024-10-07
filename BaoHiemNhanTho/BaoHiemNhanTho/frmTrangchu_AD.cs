using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyvatlieuxaydung
{
    public partial class frmTrangchu_AD : Form
    {
        public frmTrangchu_AD()
        {
            InitializeComponent();
        }

      

        private void frmTrangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketqua;
            ketqua = MessageBox.Show("Bạn có đồng ý thoát ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketqua == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn_thongtintaikhoan_Click(object sender, EventArgs e)
        {
            
          
            
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            // Clear
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmThongTinNhanVien formttnv = new frmThongTinNhanVien() { TopLevel = false, TopMost = true };
            formttnv.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formttnv);
            formttnv.Show();
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            frmDoiMatKhau formdmk = new frmDoiMatKhau();
            formdmk.Show();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmThongTinKhachHang formttkh = new frmThongTinKhachHang() { TopLevel = false, TopMost = true };
            formttkh.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formttkh);
            formttkh.Show();
        }

       

       

       
       
        private void btn_xuathang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmHoaDonXuat formxh = new frmHoaDonXuat() { TopLevel = false, TopMost = true };
            formxh.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formxh);
            formxh.Show();
        }

       

        private void btn_myteam_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmMyTeam formmyteam = new frmMyTeam() { TopLevel = false, TopMost = true };
            formmyteam.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formmyteam);
            formmyteam.Show();
        }


        

       

       

       

       
        


        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult ketqua;
            ketqua = MessageBox.Show("Bạn có đồng ý đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (ketqua == DialogResult.No)
                {
                    
                }
                else
                {
                    this.Hide();
                    frm_DangNhap frmlogin = new frm_DangNhap();
                    frmlogin.Show();
                }
            }
        }



        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
         
        }
    }

       


    
}
