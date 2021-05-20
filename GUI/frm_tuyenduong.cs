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
    public partial class frm_tuyenduong : Form
    {
        public static string ten;
        public frm_tuyenduong(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_tuyenduong_Load(object sender, EventArgs e)
        {
            List<DauXe_DTO> LstChucVu = DauXe_BUS.LayDSDauXe();
            cbodauxe.DataSource = LstChucVu;
            //NhomQuyen_DTO d1 = new NhomQuyen_DTO();
            cbodauxe.DisplayMember = "STenXe";

            //LstChucVu.Insert(0, d1);
            cbodauxe.ValueMember = "SMaDX";

            //tim kiem
            //cboTimKiem.Items.Add("Theo mã tuyến đường");
            //cboTimKiem.Items.Add("Theo tên nhân viên");
            //this.cboTimKiem.SelectedItem = "Theo tên nhân viên";


            HienThiDSLenDatagrid();
        }

        private void HienThiDSLenDatagrid()
        {


            TuyenDuong_DTO nv = new TuyenDuong_DTO();
            List<TuyenDuong_DTO> lstDauXe = TuyenDuong_BUS.LayDSTuyenDuong();
            dgvDSTuyenDuong.DataSource = lstDauXe;

            dgvDSTuyenDuong.Columns["SMaTuyen"].HeaderText = "Mã tuyến";
            dgvDSTuyenDuong.Columns["STenTuyen"].HeaderText = "Tên tuyến";
            dgvDSTuyenDuong.Columns["SNoiDi"].HeaderText = "Nơi đi";
            dgvDSTuyenDuong.Columns["SNoiDen"].HeaderText = "Nơi đến";
            dgvDSTuyenDuong.Columns["SDau"].HeaderText = "Dầu định mức(Lít)";
            dgvDSTuyenDuong.Columns["SChieuDai"].HeaderText = "Chiều dài(Km)";
            dgvDSTuyenDuong.Columns["SMaDX"].HeaderText = "Mã đầu xe";
            dgvDSTuyenDuong.Columns["STenXe"].HeaderText = "Tên xe";


            dgvDSTuyenDuong.Columns["SMaTuyen"].Width = 60;
            dgvDSTuyenDuong.Columns["STenTuyen"].Width = 150;
            dgvDSTuyenDuong.Columns["SNoiDi"].Width = 100;
            dgvDSTuyenDuong.Columns["SNoiDen"].Width = 100;
            dgvDSTuyenDuong.Columns["SDau"].Width = 80;
            dgvDSTuyenDuong.Columns["SChieuDai"].Width = 80;
            dgvDSTuyenDuong.Columns["SMaDX"].Width = 80;
            dgvDSTuyenDuong.Columns["STenXe"].Width = 120;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmatuyen.Text == "" || txttentuyen.Text == "" || txtnoiden.Text == "" || txtnoidi.Text == ""||txtdaudinhmuc.Text==""||txtchieudai.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtmatuyen.Text.Length > 5)
                {
                    MessageBox.Show("Mã tuyến tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (TuyenDuong_BUS.TimTuyenDuongTheoMa(txtmatuyen.Text) != null)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!");
                        return;
                    }
                    else
                    {
                        TuyenDuong_DTO nv = new TuyenDuong_DTO();
                        nv.SMaTuyen = txtmatuyen.Text;
                        nv.STenTuyen = txttentuyen.Text;
                        nv.SNoiDi = txtnoidi.Text;
                        nv.SNoiDen = txtnoiden.Text;
                        nv.SDau = float.Parse(txtdaudinhmuc.Text);
                        nv.SChieuDai = float.Parse(txtchieudai.Text);
                        nv.SMaDX = cbodauxe.SelectedValue.ToString();
                        if (TuyenDuong_BUS.ThemTuyenDuong(nv) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã thêm tuyến đường.");
                        WriteLog.Write(ten, "Đã thêm tuyến đường có mã số: " + txtmatuyen.Text);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtmatuyen.Text == "" || TuyenDuong_BUS.TimTuyenDuongTheoMa(txtmatuyen.Text) == null)
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
                    TuyenDuong_DTO nv = new TuyenDuong_DTO();
                    nv.SMaTuyen = txtmatuyen.Text;
                    nv.STenTuyen = txttentuyen.Text;
                    nv.SNoiDi = txtnoidi.Text;
                    nv.SNoiDen = txtnoiden.Text;
                    nv.SDau = float.Parse(txtdaudinhmuc.Text);
                    nv.SChieuDai = float.Parse(txtchieudai.Text);
                    nv.SMaDX = cbodauxe.SelectedValue.ToString();

                    if (TuyenDuong_BUS.XoaTuyenDuong(nv) == true)
                    {
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã xóa tuyến.");
                        WriteLog.Write(ten, "Đã xoá tuyến đường có mã số: " + txtmatuyen.Text);
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
            if (txtmatuyen.Text == "" || TuyenDuong_BUS.TimTuyenDuongTheoMa(txtmatuyen.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã tuyến!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa tuyến này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    TuyenDuong_DTO nv = new TuyenDuong_DTO();
                    nv.SMaTuyen = txtmatuyen.Text;
                    nv.STenTuyen = txttentuyen.Text;
                    nv.SNoiDi = txtnoidi.Text;
                    nv.SNoiDen = txtnoiden.Text;
                    nv.SDau = float.Parse(txtdaudinhmuc.Text);
                    nv.SChieuDai = float.Parse(txtchieudai.Text);
                    nv.SMaDX = cbodauxe.SelectedValue.ToString();

                    if (TuyenDuong_BUS.SuaTuyenDuong(nv) == true)
                    {
                        HienThiDSLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin.");
                        WriteLog.Write(ten, "Đã cập nhật tuyến đường có mã số: " + txtmatuyen.Text);
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
                WriteLog.Write(ten, "Đã đóng form Tuyến Đường");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedItem.ToString() == "Theo mã nhân viên")
            {
                string ma = txtTimKiem.Text;

                List<TuyenDuong_DTO> lstnv1 = TuyenDuong_BUS.TimTuyenDuongTheoMaTD(ma);
                if (lstnv1 == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvDSTuyenDuong.DataSource = lstnv1;
            }
            else if (cboTimKiem.SelectedItem.ToString() == "Theo tên nhân viên")
            {
                string ten = txtTimKiem.Text;

                List<TuyenDuong_DTO> lstnv = TuyenDuong_BUS.TimTuyenDuongTheoTen(ten);
                if (lstnv == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvDSTuyenDuong.DataSource = lstnv;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSLenDatagrid();
        }

        private void dgvDSTuyenDuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSTuyenDuong.SelectedRows[0];
            txtmatuyen.Text = r.Cells["SMaTuyen"].Value.ToString();
            txttentuyen.Text = r.Cells["STenTuyen"].Value.ToString();
            txtnoidi.Text = r.Cells["SNoiDi"].Value.ToString();
            
            txtnoiden.Text = r.Cells["SNoiDen"].Value.ToString();
            txtdaudinhmuc.Text = r.Cells["SDau"].Value.ToString();
            txtchieudai.Text = r.Cells["SChieuDai"].Value.ToString();
            cbodauxe.Text = r.Cells["STenXe"].Value.ToString();
        }
    }
}
