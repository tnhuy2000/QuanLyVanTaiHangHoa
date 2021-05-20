using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_hanghoa : Form
    {
        public static string ten;
        public frm_hanghoa(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            HienThiDSHangHoaLenDatagrid();
        }
        private void HienThiDSHangHoaLenDatagrid()
        {
            List<HangHoa_DTO> lstHangHoa = HangHoa_BUS.LayDSHangHoa();
            dgvDSHangHoa.DataSource = lstHangHoa;

            dgvDSHangHoa.Columns["SMaHang"].HeaderText = "Mã hàng hoá";
            dgvDSHangHoa.Columns["STenHang"].HeaderText = "Tên hàng hoá";
            dgvDSHangHoa.Columns["SDvt"].HeaderText = "Đơn vị tính";
            dgvDSHangHoa.Columns["SGia"].HeaderText = "Giá";
            
            

            dgvDSHangHoa.Columns["SMaHang"].Width = 80;
            dgvDSHangHoa.Columns["STenHang"].Width = 150;
            dgvDSHangHoa.Columns["SDvt"].Width = 80;
            dgvDSHangHoa.Columns["SGia"].Width = 100;
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" || txtTenHH.Text == ""||txtdonvitinh.Text==""||txtgia.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtMaHH.Text.Length > 5)
                {
                    MessageBox.Show("Mã hàng hoá tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (HangHoa_BUS.TimHangHoaTheoMa(txtMaHH.Text) != null)
                    {
                        MessageBox.Show("Mã hàng hoá đã tồn tại!");
                        return;
                    }
                    else
                    {
                        HangHoa_DTO kh = new HangHoa_DTO();
                        kh.SMaHang = txtMaHH.Text;
                        kh.STenHang = txtTenHH.Text;
                        kh.SDvt = txtdonvitinh.Text;
                        kh.SGia = int.Parse(txtgia.Text);
                        

                        if (HangHoa_BUS.ThemHangHoa(kh) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSHangHoaLenDatagrid();
                        MessageBox.Show("Đã thêm hàng hoá.");
                        WriteLog.Write(ten, "Đã thêm hàng hoá có mã số: " + txtMaHH.Text);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaHH.Text == "" || HangHoa_BUS.TimHangHoaTheoMa(txtMaHH.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã hàng hoá!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn xoá hàng hoá này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    HangHoa_DTO kh = new HangHoa_DTO();
                    kh.SMaHang = txtMaHH.Text;
                    kh.STenHang = txtTenHH.Text;
                    kh.SDvt = txtdonvitinh.Text;
                    kh.SGia = int.Parse(txtgia.Text);
                    

                    if (HangHoa_BUS.XoaHangHoa(kh) == true)
                    {
                        HienThiDSHangHoaLenDatagrid();
                        MessageBox.Show("Đã xóa hàng hoá.");
                        WriteLog.Write(ten, "Đã xoá hàng hoá có mã số: " + txtMaHH.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được.");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaHH.Text == "" || HangHoa_BUS.TimHangHoaTheoMa(txtMaHH.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã hàng hoá!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa hàng hoá này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    HangHoa_DTO kh = new HangHoa_DTO();
                    kh.SMaHang = txtMaHH.Text;
                    kh.STenHang = txtTenHH.Text;
                    kh.SDvt = txtdonvitinh.Text;
                    kh.SGia = int.Parse(txtgia.Text);
                    

                    if (HangHoa_BUS.SuaHangHoa(kh) == true)
                    {
                        HienThiDSHangHoaLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin hàng hoá.");
                        WriteLog.Write(ten, "Đã cập nhật hàng hoá có mã số: " + txtMaHH.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được.");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn đóng form!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tr==DialogResult.OK)
            {
                this.Close();
                WriteLog.Write(ten, "Đã đóng form Hàng Hoá");
            }    
        }

        private void dgvDSHangHoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSHangHoa.SelectedRows[0];
            txtMaHH.Text = r.Cells["SMaHang"].Value.ToString();
            txtTenHH.Text = r.Cells["STenHang"].Value.ToString();
            txtdonvitinh.Text = r.Cells["SDvt"].Value.ToString();
            txtgia.Text = r.Cells["SGia"].Value.ToString();
            
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;

            List<HangHoa_DTO> lstnv = HangHoa_BUS.TimHangHoaTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvDSHangHoa.DataSource = lstnv;
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSHangHoaLenDatagrid();
        }
    }
}
