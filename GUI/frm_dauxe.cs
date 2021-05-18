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
    public partial class frm_dauxe : Form
    {
        public static string ten;
        public frm_dauxe(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_dauxe_Load(object sender, EventArgs e)
        {
            
            //combobox chucvu

            List<TaiXe_DTO> LstChucVu = TaiXe_BUS.LayDSTaiXe();
            cbotentaixe.DataSource = LstChucVu;
            //NhomQuyen_DTO d1 = new NhomQuyen_DTO();
            cbotentaixe.DisplayMember = "SHoTen";

            //LstChucVu.Insert(0, d1);
            cbotentaixe.ValueMember = "SMaTX";
            HienThiDSDauXeLenDatagrid();
        }
        private void HienThiDSDauXeLenDatagrid()
        {
            DauXe_DTO nv = new DauXe_DTO();
            List<DauXe_DTO> lstDauXe = DauXe_BUS.LayDSDauXe();
            dgvDSDauXe.DataSource = lstDauXe;
            //cbotentaixe.DataSource = nv.SHoTen;

            dgvDSDauXe.Columns["SMaDX"].HeaderText = "Mã đầu xe";
            dgvDSDauXe.Columns["SBienSo"].HeaderText = "Biển số";
            dgvDSDauXe.Columns["STenXe"].HeaderText = "Tên xe";
            dgvDSDauXe.Columns["SMauSon"].HeaderText = "Màu sơn";
            dgvDSDauXe.Columns["SDungTich"].HeaderText = "Dung tích(cm3)";
            dgvDSDauXe.Columns["DtNamSanXuat"].HeaderText = "Năm sản xuất";
            dgvDSDauXe.Columns["SMaTX"].HeaderText = "Mã tài xê";
            dgvDSDauXe.Columns["SHoTen"].HeaderText = "Tên tài xế";

            dgvDSDauXe.Columns["SMaDX"].Width = 70;
            dgvDSDauXe.Columns["SBienSo"].Width = 100;
            dgvDSDauXe.Columns["STenXe"].Width = 150;
            dgvDSDauXe.Columns["SMauSon"].Width = 80;
            dgvDSDauXe.Columns["SDungTich"].Width = 100;
            dgvDSDauXe.Columns["DtNamSanXuat"].Width = 120;
            dgvDSDauXe.Columns["SMaTX"].Width = 120;
            dgvDSDauXe.Columns["SHoTen"].Width = 120;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtbienso.Text == "" || txtdungtich.Text == "" ||txtmadauxe.Text==""||txtmauson.Text==""||txttenxe.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtmadauxe.Text.Length > 5)
                {
                    MessageBox.Show("Mã tài xế tối đa 5 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (DauXe_BUS.TimDauXeTheoMa(txtmadauxe.Text) != null)
                    {
                        MessageBox.Show("Mã tài xế đã tồn tại!");
                        return;
                    }
                    else
                    {
                        DauXe_DTO kh = new DauXe_DTO();
                        kh.SMaDX = txtmadauxe.Text;
                        kh.SBienSo = txtbienso.Text;
                        kh.STenXe = txttenxe.Text;
                        kh.SMauSon = txtmauson.Text;
                        kh.SDungTich = int.Parse(txtdungtich.Text);
                        kh.DtNamSanXuat = DateTime.Parse(dtnamsx.Text);

                        kh.SMaTX = cbotentaixe.SelectedValue.ToString();
                        
                        if (DauXe_BUS.ThemDauXe(kh) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSDauXeLenDatagrid();
                        MessageBox.Show("Đã thêm tài xế.");
                        WriteLog.Write(ten, "Đã thêm tài xế có mã số: " + txtmadauxe.Text);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtmadauxe.Text == "" || DauXe_BUS.TimDauXeTheoMa(txtmadauxe.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn xoá đầu xe này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    DauXe_DTO kh = new DauXe_DTO();
                    kh.SMaDX = txtmadauxe.Text;
                    kh.SBienSo = txtbienso.Text;
                    kh.STenXe = txttenxe.Text;
                    kh.SMauSon = txtmauson.Text;
                    kh.SDungTich = int.Parse(txtdungtich.Text);
                    kh.DtNamSanXuat = DateTime.Parse(dtnamsx.Text);

                    kh.SMaTX = cbotentaixe.SelectedValue.ToString();

                    if (DauXe_BUS.XoaDauXe(kh) == true)
                    {
                        HienThiDSDauXeLenDatagrid();
                        MessageBox.Show("Đã xóa đầu xe.");
                        WriteLog.Write(ten, "Đã xoá đầu xe có mã số: " + txtmadauxe.Text);
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
            if (txtmadauxe.Text == "" || DauXe_BUS.TimDauXeTheoMa(txtmadauxe.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa đầu xe này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    DauXe_DTO kh = new DauXe_DTO();
                    kh.SMaDX = txtmadauxe.Text;
                    kh.SBienSo = txtbienso.Text;
                    kh.STenXe = txttenxe.Text;
                    kh.SMauSon = txtmauson.Text;
                    kh.SDungTich = int.Parse(txtdungtich.Text);
                    kh.DtNamSanXuat = DateTime.Parse(dtnamsx.Text);

                    kh.SMaTX = cbotentaixe.SelectedValue.ToString();

                    if (DauXe_BUS.SuaDauXe(kh) == true)
                    {
                        HienThiDSDauXeLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin.");
                        WriteLog.Write(ten, "Đã cập nhật đầu xe có mã số: " + txtmadauxe.Text);
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
                WriteLog.Write(ten, "Đã đóng form Đầu Xe");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSDauXeLenDatagrid();
        }

        private void dgvDSDauXe_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSDauXe.SelectedRows[0];
            txtmadauxe.Text = r.Cells["SMaDX"].Value.ToString();
            txtbienso.Text = r.Cells["SBienSo"].Value.ToString();
            txttenxe.Text = r.Cells["STenXe"].Value.ToString();
            txtmauson.Text = r.Cells["SMauSon"].Value.ToString();
            txtdungtich.Text = r.Cells["SDungTich"].Value.ToString();
            
            dtnamsx.Text = r.Cells["DtNamSanXuat"].Value.ToString();
            //cbotentaixe.SelectedValue = r.Cells["SMaTaiXe"].Value;
            cbotentaixe.Text = r.Cells["SHoTen"].Value.ToString();
            

        }
    }
}
