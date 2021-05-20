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
    public partial class frm_nhanvien : Form
    {
        public static string ten;
        public frm_nhanvien(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            List<NhomQuyen_DTO> LstChucVu = NhomQuyen_BUS.LayQuyen();
            cboChucVu.DataSource = LstChucVu;
            //NhomQuyen_DTO d1 = new NhomQuyen_DTO();
            cboChucVu.DisplayMember = "STenQuyen";

            //LstChucVu.Insert(0, d1);
            cboChucVu.ValueMember = "SMaQuyen";


            cboTimKiem.Items.Add("Theo mã nhân viên");
            cboTimKiem.Items.Add("Theo tên nhân viên");
            this.cboTimKiem.SelectedItem = "Theo tên nhân viên";


            HienThiDSNhanVienLenDatagrid();
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            

            NhanVien_DTO nv = new NhanVien_DTO();
            List<NhanVien_DTO> lstDauXe = NhanVien_BUS.LayDSNhanVien();
            dgvDSNhanVien.DataSource = lstDauXe;

            dgvDSNhanVien.Columns["SMaNV"].HeaderText = "Mã NV";
            dgvDSNhanVien.Columns["SHoTen"].HeaderText = "Họ tên";
            dgvDSNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns["SPhai"].HeaderText = "Phái";
            dgvDSNhanVien.Columns["SSdt"].HeaderText = "Số điện thoại";
            dgvDSNhanVien.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgvDSNhanVien.Columns["SMaQuyen"].HeaderText = "Mã CV";
            dgvDSNhanVien.Columns["STenQuyen"].HeaderText = "Tên CV";


            dgvDSNhanVien.Columns["SMaNV"].Width = 60;
            dgvDSNhanVien.Columns["SHoTen"].Width = 120;
            dgvDSNhanVien.Columns["DtNgaySinh"].Width = 50;
            dgvDSNhanVien.Columns["SPhai"].Width = 50;
            dgvDSNhanVien.Columns["SSdt"].Width = 80;
            dgvDSNhanVien.Columns["SDiaChi"].Width = 80;
            dgvDSNhanVien.Columns["SMaQuyen"].Width = 50;
            dgvDSNhanVien.Columns["STenQuyen"].Width = 120;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoTen.Text == ""||txtDiaChi.Text==""||txtDienThoai.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtMaNV.Text.Length > 5)
                {
                    MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (KhachHang_BUS.TimKhachHangTheoMa(txtMaNV.Text) != null)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!");
                        return;
                    }
                    else
                    {
                        NhanVien_DTO nv = new NhanVien_DTO();
                        nv.SMaNV = txtMaNV.Text;
                        nv.SHoTen = txtHoTen.Text;
                        nv.DtNgaySinh = DateTime.Parse(dtNgaySinh.Text);
                        if (radNam.Checked == true)
                        {
                            nv.SPhai = "Nam";
                        }
                        else
                        {
                            nv.SPhai = "Nữ";
                        }
                        nv.SSdt = txtDienThoai.Text;
                        nv.SDiaChi = txtDiaChi.Text;
                        nv.SMaQuyen = cboChucVu.SelectedValue.ToString();
                        if (NhanVien_BUS.ThemNhanVien(nv) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSNhanVienLenDatagrid();
                        MessageBox.Show("Đã thêm nhân viên.");
                        WriteLog.Write(ten, "Đã thêm nhân viên có mã số: " + txtMaNV.Text);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn xoá nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.SMaNV = txtMaNV.Text;
                    nv.SHoTen = txtHoTen.Text;
                    nv.DtNgaySinh = DateTime.Parse(dtNgaySinh.Text);
                    if (radNam.Checked == true)
                    {
                        nv.SPhai = "Nam";
                    }
                    else
                    {
                        nv.SPhai = "Nữ";
                    }
                    nv.SSdt = txtDienThoai.Text;
                    nv.SDiaChi = txtDiaChi.Text;
                    nv.SMaQuyen = cboChucVu.SelectedValue.ToString();

                    if (NhanVien_BUS.XoaNhanVien(nv) == true)
                    {
                        HienThiDSNhanVienLenDatagrid();
                        MessageBox.Show("Đã xóa nhân viên.");
                        WriteLog.Write(ten, "Đã xoá nhân viên có mã số: " + txtMaNV.Text);
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
            if (txtMaNV.Text == "" || NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.SMaNV = txtMaNV.Text;
                    nv.SHoTen = txtHoTen.Text;
                    nv.DtNgaySinh = DateTime.Parse(dtNgaySinh.Text);
                    if (radNam.Checked == true)
                    {
                        nv.SPhai = "Nam";
                    }
                    else
                    {
                        nv.SPhai = "Nữ";
                    }
                    nv.SSdt = txtDienThoai.Text;
                    nv.SDiaChi = txtDiaChi.Text;
                    nv.SMaQuyen = cboChucVu.SelectedValue.ToString();

                    if (NhanVien_BUS.SuaNhanVien(nv) == true)
                    {
                        HienThiDSNhanVienLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin nhân viên.");
                        WriteLog.Write(ten, "Đã cập nhật nhân viên có mã số: " + txtMaNV.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được.");
                    }
                }
            }
        }

        private void dgvDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSNhanVien.SelectedRows[0];
            txtMaNV.Text = r.Cells["SMaNV"].Value.ToString();
            txtHoTen.Text = r.Cells["SHoTen"].Value.ToString();
            dtNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDienThoai.Text = r.Cells["SSdt"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            cboChucVu.Text = r.Cells["STenQuyen"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedItem.ToString() == "Theo mã nhân viên")
            {
                string ma = txtTimKiem.Text;

                List<NhanVien_DTO> lstnv1 = NhanVien_BUS.TimNhanVienTheoMaNV(ma);
                if (lstnv1 == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvDSNhanVien.DataSource = lstnv1;
            }
            else if (cboTimKiem.SelectedItem.ToString() == "Theo tên nhân viên")
            {
                string ten = txtTimKiem.Text;

                List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoHoTen(ten);
                if (lstnv == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvDSNhanVien.DataSource = lstnv;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn đóng form!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                this.Close();
                WriteLog.Write(ten, "Đã đóng form nhân viên");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
        }
    }
}
