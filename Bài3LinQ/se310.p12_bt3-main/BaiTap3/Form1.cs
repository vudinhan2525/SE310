using System.Collections.Generic;
namespace BaiTap3
{
    public partial class Form1 : Form
    {
        List<SanPham> list = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();

            LoadProduct();
        }

        public void addBtn_Click(object sender, EventArgs e)
        {
            bool exist = false;
            list.Where(item => item.MaSP == tbmasp.Text).ToList().ForEach(existItem =>
            {
                existItem.MaSP = tbmasp.Text;
                existItem.TenSP = tbtensp.Text;
                existItem.DonGia = Convert.ToDouble(tbdongia.Text);
                existItem.SoLuong = Convert.ToInt32(tbsoluong.Text);
                existItem.XuatXu = tbxuatxu.Text;
                existItem.NgayHetHan = ngayhethan.Value;
                exist = true;
                LoadProduct();

            });
            if (exist) return;
            list.Add(new SanPham(tbmasp.Text, tbtensp.Text, Convert.ToInt32(tbsoluong.Text), Convert.ToDouble(tbdongia.Text), tbxuatxu.Text, ngayhethan.Value));
            LoadProduct();
            tbmasp.Text = "";
            tbtensp.Text = "";
            tbsoluong.Text = "";
            tbdongia.Text = "";
            tbxuatxu.Text = "";
        }

        public void LoadProduct()
        {
            dgv.Rows.Clear();
            foreach (SanPham product in list)
            {
                dgv.Rows.Add(product.MaSP, product.TenSP, product.SoLuong, product.DonGia, product.XuatXu, product.NgayHetHan);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            SanPham item = list.Find(item => item.MaSP == tbmasp.Text);
            if (item != null)
            {
                list.RemoveAt(list.IndexOf(item));
                LoadProduct();
            }
            else MessageBox.Show("Ma san pham khong hop le");
            tbmasp.Text = "";

        }

        private void delXuatXuBtn_Click(object sender, EventArgs e)
        {
            List<SanPham> newList = list.Where(item => item.XuatXu == delXuatXu.Text).ToList();
            if (newList.Count != 0)
            {
                foreach (SanPham item in newList)
                {
                    list.Remove(item);
                }
                LoadProduct();
            }
            else MessageBox.Show("Khong tim duoc san pham phu hop");
            delXuatXu.Text = "";
        }

        private void btnSanPhamHopLe_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                SanPham item = list.Where(item => item.NgayHetHan < DateTime.Now.Date).First();
                if (item != null) MessageBox.Show("Co san pham het han");
                MessageBox.Show("Khong co san pham het han");
            }
            else MessageBox.Show("Khong co san pham trong kho");
        }

        private void delAllBtn_Click(object sender, EventArgs e)
        {
            list.Clear();
            LoadProduct();
        }

        private void delSanPhamQuaHanBtn_Click(object sender, EventArgs e)
        {
            list.RemoveAll(product => product.NgayHetHan < DateTime.Now.Date);
            LoadProduct();
        }

        private void sanPhamCoDGCaoNhatBtn_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            SanPham sanPham = new SanPham();
            double max = 0;
            if (list.Count == 0)
            {
                MessageBox.Show("Khong co san pham trong kho");
                return;
            }
            else if (list.Count == 1) sanPham = list[0];
            else
            {
                sanPham = list.OrderByDescending(item => item.DonGia).First();
            }
            if (sanPham != null)
            {
                dgv2.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.SoLuong, sanPham.DonGia, sanPham.XuatXu, sanPham.NgayHetHan);
            }

        }

        private void sanPhamTuNhatBanBtn_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            if (list.Count == 0)
            {
                MessageBox.Show("Khong co san pham trong kho");
                return;
            }
            var newSanPham = list.Where(item => item.XuatXu == "Nhat Ban").ToList();
            if (newSanPham != null)
            {
                dgv2.Rows.Add(newSanPham[0].MaSP, newSanPham[0].TenSP, newSanPham[0].SoLuong, newSanPham[0].DonGia, newSanPham[0].XuatXu, newSanPham[0].NgayHetHan);
            }
        }

        private void sanPhamQuaHanBtn_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            if (list.Count == 0)
            {
                MessageBox.Show("Khong co san pham trong kho");
                return;
            }
            List<SanPham> newList = list.Where(item => item.NgayHetHan < DateTime.Now.Date).OrderBy(item => item.NgayHetHan).ToList();
            foreach (SanPham newSanPham in newList)
            {
                dgv2.Rows.Add(newSanPham.MaSP, newSanPham.TenSP, newSanPham.SoLuong, newSanPham.DonGia, newSanPham.XuatXu, newSanPham.NgayHetHan);
            }
        }

        private void sanPhamTrongPhamViBtn_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            List<SanPham> newList = list.Where(item => (item.DonGia >= Convert.ToDouble(tbA.Text) && item.DonGia <= Convert.ToDouble(tbB.Text))).ToList();
            if (newList.Count > 0)
            {
                foreach (SanPham newSanPham in newList)
                {
                    dgv2.Rows.Add(newSanPham.MaSP, newSanPham.TenSP, newSanPham.SoLuong, newSanPham.DonGia, newSanPham.XuatXu, newSanPham.NgayHetHan);
                }
            }
            else MessageBox.Show("Khong co san pham phu hop");
        }
    }

    public class SanPham
    {
        private string? maSP;
        private string? tenSP;
        private int soLuong;
        private double donGia;
        private string? xuatXu;
        private DateTime ngayHetHan;
        public string? MaSP { get { return maSP; } set { maSP = value; } }
        public string? TenSP { get { return tenSP; } set { tenSP = value; } }
        public int SoLuong { get { return soLuong; } set { soLuong = value; } }
        public double DonGia { get { return donGia; } set { donGia = value; } }
        public string? XuatXu { get { return xuatXu; } set { xuatXu = value; } }
        public DateTime NgayHetHan { get { return ngayHetHan; } set { ngayHetHan = value; } }

        public SanPham() { }
        public SanPham(string maSP, string tenSP, int soLuong, double donGia, string xuatXu, DateTime ngayHetHan)
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            DonGia = donGia;
            XuatXu = xuatXu;
            NgayHetHan = ngayHetHan;
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            DonGia = donGia;
            XuatXu = xuatXu;
            NgayHetHan = ngayHetHan;
        }

    }
}