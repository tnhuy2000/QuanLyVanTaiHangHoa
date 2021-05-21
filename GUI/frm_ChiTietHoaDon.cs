using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frm_ChiTietHoaDon : Form
    {
        public static string mahoadon;
        public static string ten;
        public frm_ChiTietHoaDon(string ma,string tendangnhap)
        {
            InitializeComponent();
            //mahoadon = ma;
            ten = tendangnhap;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbomahoadon.Text == "" || cbotenhanghoa.Text == "" || txtsoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (cbomahoadon.Text.Length > 5)
                {
                    MessageBox.Show("Mã hoá đơn tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (ChiTietHoaDon_BUS.TimChiTietHoaDonTheoMa(cbomahoadon.Text,cbotenhanghoa.SelectedValue.ToString()) != null)
                    {
                        MessageBox.Show("Chi tiết hoá đơn đã tồn tại!");
                        return;
                    }
                    else
                    {
                        ChiTietHoaDon_DTO nv = new ChiTietHoaDon_DTO();
                        nv.SMahd = cbomahoadon.SelectedValue.ToString();
                        nv.SMaHang = cbotenhanghoa.SelectedValue.ToString();
                        nv.SSoLuong = int.Parse(txtsoluong.Text);
                        if (ChiTietHoaDon_BUS.ThemChiTietHoaDon(nv) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã thêm hoá đơn.");
                        WriteLog.Write(ten, "Đã thêm hoá đơn có mã số: " + cbomahoadon.Text);
                    }
                }
            }
        }

        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            //cbomahoadon.Text = mahoadon;
            List<HangHoa_DTO> LstChucVu = HangHoa_BUS.LayDSHangHoa();
            cbotenhanghoa.DataSource = LstChucVu;
            cbotenhanghoa.DisplayMember = "STenHang";
            //LstChucVu.Insert(0, d1);
            cbotenhanghoa.ValueMember = "SMaHang";

            //combobox ma hoa don
            List<HoaDon_DTO> LstChucVu1 = HoaDon_BUS.LayDSHoaDon();
            cbomahoadon.DataSource = LstChucVu1;
           // cbomahoadon.DisplayMember = "SMahd";
            //LstChucVu.Insert(0, d1);
            cbomahoadon.ValueMember = "SMahd";
            HienThiDSLenDatagrid();
        }
        private void HienThiDSLenDatagrid()
        {
            ChiTietHoaDon_DTO nv = new ChiTietHoaDon_DTO();
            List<ChiTietHoaDon_DTO> lstDauXe = ChiTietHoaDon_BUS.LayDSChiTietHoaDon();
            dgvDSCTHH.DataSource = lstDauXe;

            dgvDSCTHH.Columns["SMahd"].HeaderText = "Mã hoá đơn";
            dgvDSCTHH.Columns["SSoLuong"].HeaderText = "Số lượng";
            dgvDSCTHH.Columns["SMaHang"].HeaderText = "Mã hàng hoá";
            dgvDSCTHH.Columns["STenHang"].HeaderText = "Tên hàng hoá";
            
            dgvDSCTHH.Columns["SDvt"].HeaderText = "Đơn vị tính";
            dgvDSCTHH.Columns["SGia"].HeaderText = "Giá";


            dgvDSCTHH.Columns["SMahd"].Width = 80;
            dgvDSCTHH.Columns["SMaHang"].Width = 80;
            dgvDSCTHH.Columns["SMaHang"].Visible = false;
            dgvDSCTHH.Columns["STenHang"].Width = 100;
            dgvDSCTHH.Columns["SSoLuong"].Width = 80;
            dgvDSCTHH.Columns["SDvt"].Width = 80;
            dgvDSCTHH.Columns["SGia"].Width = 80;
        }

        private void dgvDSCTHH_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSCTHH.SelectedRows[0];
            cbomahoadon.Text = r.Cells["SMahd"].Value.ToString();
            cbotenhanghoa.Text = r.Cells["STenHang"].Value.ToString();
            txtsoluong.Text = r.Cells["SSoLuong"].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (cbomahoadon.Text == "" || HoaDon_BUS.TimHoaDonTheoMa(cbomahoadon.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã !");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn xoá hoá đơn này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    ChiTietHoaDon_DTO nv = new ChiTietHoaDon_DTO();
                    nv.SMahd = cbomahoadon.SelectedValue.ToString();
                    nv.SMaHang = cbotenhanghoa.SelectedValue.ToString();
                    nv.SSoLuong = int.Parse(txtsoluong.Text);
                    

                    if (ChiTietHoaDon_BUS.XoaChiTietHoaDon(nv) == true)
                    {
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã xóa.");
                        WriteLog.Write(ten, "Đã xoá tuyến đường có mã số: " + cbomahoadon.Text);
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
            if (cbomahoadon.Text == "" || HoaDon_BUS.TimHoaDonTheoMa(cbomahoadon.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa hoá đơn này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    
                    ChiTietHoaDon_DTO nv = new ChiTietHoaDon_DTO();
                    nv.SMahd = cbomahoadon.SelectedValue.ToString();
                    nv.SMaHang = cbotenhanghoa.SelectedValue.ToString();
                    nv.SSoLuong = int.Parse(txtsoluong.Text);

                    if (ChiTietHoaDon_BUS.SuaChiTietHoaDon(nv) == true)
                    {
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin.");
                        WriteLog.Write(ten, "Đã cập nhật hoá đơn có mã số: " + cbomahoadon.Text);
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
            if (tr == DialogResult.OK)
            {
                this.Close();
                WriteLog.Write(ten, "Đã đóng form Hoá Đơn");
            }
        }

        private void cbomahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbomahoadon.SelectedValue.ToString();

            List<ChiTietHoaDon_DTO> lstnv1 = ChiTietHoaDon_BUS.TimChiTietHoaDonTheoMaHoaDon(ma);
            if (lstnv1 == null)
            {
                //MessageBox.Show("Chưa có chi tiết nào!");
                return;
            }
            dgvDSCTHH.DataSource = lstnv1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSLenDatagrid();
        }
    }
}
