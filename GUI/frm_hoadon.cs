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
    public partial class frm_hoadon : Form
    {
        public static string ten;
        public frm_hoadon(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_hoadon1_Load(object sender, EventArgs e)
        {
            // combox tuyen đường

            List<TuyenDuong_DTO> LstChucVu = TuyenDuong_BUS.LayDSTuyenDuong();
            cbotentuyenduong.DataSource = LstChucVu;
            cbotentuyenduong.DisplayMember = "STenTuyen";
            //LstChucVu.Insert(0, d1);
            cbotentuyenduong.ValueMember = "SMaTuyen";

            //combobox khách hàng
            List<KhachHang_DTO> LstChucVu1 = KhachHang_BUS.LayDSKhachHang();
            cbotenkhachhang.DataSource = LstChucVu1;
            cbotenkhachhang.DisplayMember = "sHoTen";
            //LstChucVu.Insert(0, d1);
            cbotenkhachhang.ValueMember = "sMaKH";


            //commbobox nhân viên
            List<NhanVien_DTO> LstChucVu2 = NhanVien_BUS.LayDSNhanVien();
            cbonhanvienlap.DataSource = LstChucVu2;
            cbonhanvienlap.DisplayMember = "sHoTen"; 
            //LstChucVu.Insert(0, d1);
            cbonhanvienlap.ValueMember = "SMaNV";

            HienThiDSLenDatagrid();
        }
        private void HienThiDSLenDatagrid()
        {


            HoaDon_DTO nv = new HoaDon_DTO();
            List<HoaDon_DTO> lstDauXe = HoaDon_BUS.LayDSHoaDon();
            dgvDSHoaDon.DataSource = lstDauXe;

            dgvDSHoaDon.Columns["SMahd"].HeaderText = "Mã hoá đơn";
            dgvDSHoaDon.Columns["SMatd"].HeaderText = "Mã tuyến";
            dgvDSHoaDon.Columns["SMakh"].HeaderText = "Mã KH";
            dgvDSHoaDon.Columns["SMaNV"].HeaderText = "Mã NV";
            dgvDSHoaDon.Columns["DtNgayLap"].HeaderText = "Ngày lập";
            dgvDSHoaDon.Columns["DtNgayGiao"].HeaderText = "Ngày giao";
            dgvDSHoaDon.Columns["STongGiaTri"].HeaderText = "Tổng trị giá";
            dgvDSHoaDon.Columns["STenTuyen"].HeaderText = "Tên tuyến";
            dgvDSHoaDon.Columns["SHoTenkH"].HeaderText = "Tên KH";
            dgvDSHoaDon.Columns["SHoTenNV"].HeaderText = "Nhân viên lập";



            dgvDSHoaDon.Columns["SMahd"].Width = 80;
            dgvDSHoaDon.Columns["SMatd"].Width = 80;
            dgvDSHoaDon.Columns["SMakh"].Width = 80;
            dgvDSHoaDon.Columns["SMaNV"].Width = 80;
            dgvDSHoaDon.Columns["DtNgayLap"].Width = 100;
            dgvDSHoaDon.Columns["DtNgayGiao"].Width = 100;
            dgvDSHoaDon.Columns["STongGiaTri"].Width = 60;
            dgvDSHoaDon.Columns["STenTuyen"].Width = 150;
            dgvDSHoaDon.Columns["SHoTenkH"].Width = 150;
            dgvDSHoaDon.Columns["SHoTenNV"].Width = 120;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmahoadon.Text == "" || txttongtrigia.Text == "" || cbonhanvienlap.Text == "" || cbotenkhachhang.Text == "" || cbotentuyenduong.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtmahoadon.Text.Length > 5)
                {
                    MessageBox.Show("Mã hoá đơn tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (HoaDon_BUS.TimHoaDonTheoMa(txtmahoadon.Text) != null)
                    {
                        MessageBox.Show("Mã hoá đơn đã tồn tại!");
                        return;
                    }
                    else
                    {
                        HoaDon_DTO nv = new HoaDon_DTO();
                        nv.SMahd = txtmahoadon.Text;
                        nv.SMatd = cbotentuyenduong.SelectedValue.ToString();
                        nv.SMakh = cbotenkhachhang.SelectedValue.ToString();
                        nv.SMaNV = cbonhanvienlap.SelectedValue.ToString();
                        nv.DtNgayLap = DateTime.Parse(dtngaylap.Text);
                        nv.DtNgayGiao = DateTime.Parse(dtngaygiao.Text);
                        nv.STongGiaTri = int.Parse(txttongtrigia.Text);
                        if (HoaDon_BUS.ThemHoaDon(nv) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã thêm hoá đơn.");
                        WriteLog.Write(ten, "Đã thêm hoá đơn có mã số: " + txtmahoadon.Text);
                    }
                }
            }
        }

        private void dgvDSHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSHoaDon.SelectedRows[0];
            txtmahoadon.Text = r.Cells["SMahd"].Value.ToString();
            cbotentuyenduong.Text = r.Cells["STenTuyen"].Value.ToString();
            cbotenkhachhang.Text = r.Cells["SHoTenkH"].Value.ToString();

            cbonhanvienlap.Text = r.Cells["SHoTenNV"].Value.ToString();
            dtngaylap.Text = r.Cells["DtNgayLap"].Value.ToString();
            dtngaygiao.Text = r.Cells["DtNgayGiao"].Value.ToString();
            txttongtrigia.Text = r.Cells["STongGiaTri"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtmahoadon.Text == "" || HoaDon_BUS.TimHoaDonTheoMa(txtmahoadon.Text) == null)
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
                    HoaDon_DTO nv = new HoaDon_DTO();
                    nv.SMahd = txtmahoadon.Text;
                    nv.SMatd = cbotentuyenduong.SelectedValue.ToString();
                    nv.SMakh = cbotenkhachhang.SelectedValue.ToString();
                    nv.SMaNV = cbonhanvienlap.SelectedValue.ToString();
                    nv.DtNgayLap = DateTime.Parse(dtngaylap.Text);
                    nv.DtNgayGiao = DateTime.Parse(dtngaygiao.Text);
                    nv.STongGiaTri = int.Parse(txttongtrigia.Text);

                    if (HoaDon_BUS.XoaHoaDon(nv) == true)
                    {
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã xóa.");
                        WriteLog.Write(ten, "Đã xoá tuyến đường có mã số: " + txtmahoadon.Text);
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
            if (txtmahoadon.Text == "" || HoaDon_BUS.TimHoaDonTheoMa(txtmahoadon.Text) == null)
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
                    HoaDon_DTO nv = new HoaDon_DTO();
                    nv.SMahd = txtmahoadon.Text;
                    nv.SMatd = cbotentuyenduong.SelectedValue.ToString();
                    nv.SMakh = cbotenkhachhang.SelectedValue.ToString();
                    nv.SMaNV = cbonhanvienlap.SelectedValue.ToString();
                    nv.DtNgayLap = DateTime.Parse(dtngaylap.Text);
                    nv.DtNgayGiao = DateTime.Parse(dtngaygiao.Text);
                    nv.STongGiaTri = int.Parse(txttongtrigia.Text);

                    if (HoaDon_BUS.SuaHoaDon(nv) == true)
                    {
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin.");
                        WriteLog.Write(ten, "Đã cập nhật hoá đơn có mã số: " + txtmahoadon.Text);
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

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon f = new frm_ChiTietHoaDon(txtmahoadon.Text,ten);
            f.Show();
        }
    }
}
