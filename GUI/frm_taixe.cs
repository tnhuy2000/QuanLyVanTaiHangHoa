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
    public partial class frm_taixe : Form
    {
        public static string ten;
        public frm_taixe(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_taixe_Load(object sender, EventArgs e)
        {
            HienThiDSTaiXeLenDatagrid();
        }

        private void HienThiDSTaiXeLenDatagrid()
        {
            List<TaiXe_DTO> lstTaiXe = TaiXe_BUS.LayDSTaiXe();
            dgvDSTaiXe.DataSource = lstTaiXe;

            dgvDSTaiXe.Columns["SMaTX"].HeaderText = "Mã số";
            dgvDSTaiXe.Columns["SHoTen"].HeaderText = "Họ tên";
            dgvDSTaiXe.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgvDSTaiXe.Columns["SDienThoai"].HeaderText = "Điện thoại";
            dgvDSTaiXe.Columns["SCmnd"].HeaderText = "CMND";

            dgvDSTaiXe.Columns["SMaTX"].Width = 80;
            dgvDSTaiXe.Columns["SHoTen"].Width = 150;
            dgvDSTaiXe.Columns["SDiaChi"].Width = 200;
            dgvDSTaiXe.Columns["SDienThoai"].Width = 120;
            dgvDSTaiXe.Columns["SCmnd"].Width = 100;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtMaTX.Text.Length > 5)
                {
                    MessageBox.Show("Mã tài xế tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (TaiXe_BUS.TimTaiXeTheoMa(txtMaTX.Text) != null)
                    {
                        MessageBox.Show("Mã tài xế đã tồn tại!");
                        return;
                    }
                    else
                    {
                        TaiXe_DTO kh = new TaiXe_DTO();
                        kh.SMaTX = txtMaTX.Text;
                        kh.SHoTen = txtHoTen.Text;
                        kh.SDiaChi = txtDiaChi.Text;

                        kh.SDienThoai = txtDienThoai.Text;
                        kh.SCmnd = txtCmnd.Text;
                        if (TaiXe_BUS.ThemTaiXe(kh) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSTaiXeLenDatagrid();
                        MessageBox.Show("Đã thêm tài xế.");
                        WriteLog.Write(ten, "Đã thêm tài xế có mã số: " + txtMaTX.Text);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaTX.Text == "" || TaiXe_BUS.TimTaiXeTheoMa(txtMaTX.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã tài xế!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn xoá tài xế này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    TaiXe_DTO kh = new TaiXe_DTO();
                    kh.SMaTX = txtMaTX.Text;
                    kh.SHoTen = txtHoTen.Text;
                    kh.SDienThoai = txtDienThoai.Text;
                    kh.SDiaChi = txtDiaChi.Text;
                    kh.SCmnd = txtCmnd.Text;

                    if (TaiXe_BUS.XoaTaiXe(kh) == true)
                    {
                        HienThiDSTaiXeLenDatagrid();
                        MessageBox.Show("Đã xóa tài xế.");
                        WriteLog.Write(ten, "Đã xoá tài xế có mã số: " + txtMaTX.Text);
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
            if (txtMaTX.Text == "" || TaiXe_BUS.TimTaiXeTheoMa(txtMaTX.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã tài xế!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa tài xế này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    TaiXe_DTO kh = new TaiXe_DTO();
                    kh.SMaTX = txtMaTX.Text;
                    kh.SHoTen = txtHoTen.Text;
                    kh.SDiaChi = txtDiaChi.Text;
                    kh.SDienThoai = txtDienThoai.Text;
                    kh.SCmnd = txtCmnd.Text;

                    if (TaiXe_BUS.SuaTaiXe(kh) == true)
                    {
                        HienThiDSTaiXeLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin tài xế.");
                        WriteLog.Write(ten, "Đã cập nhật tài xế có mã số: " + txtMaTX.Text);
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
                WriteLog.Write(ten, "Đã đóng form Tài Xế");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;

            List<TaiXe_DTO> lstnv = TaiXe_BUS.TimTaiXeTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvDSTaiXe.DataSource = lstnv;
        }

        private void dgvDSTaiXe_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSTaiXe.SelectedRows[0];
            txtMaTX.Text = r.Cells["SMaTX"].Value.ToString();
            txtHoTen.Text = r.Cells["SHoTen"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = r.Cells["SDienThoai"].Value.ToString();
            txtCmnd.Text = r.Cells["SCmnd"].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSTaiXeLenDatagrid();
        }
    }
}
