using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBTL2
{
    public partial class Form1 : Form
    {
        List<SinhVien> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<SinhVien> ();
            
        }
       
        class SinhVien
        {
            public string name { set; get; }
            public string gioitinh { set; get; }
            public string ngaysinh { set; get; }
            public string diachi { set; get; }
            public string lop { set; get; }
            public int masv { set; get; }
            public SinhVien()
            {
                name = gioitinh = ngaysinh = diachi = lop = "";
                masv = 0;
            }
            public SinhVien(string name, int masv, string gioitinh, string ngaysinh,  string lop, string diachi)
            {
                this.name = name;
                this.gioitinh = gioitinh;
                this.ngaysinh = ngaysinh;
                this.diachi = diachi;
                this.lop = lop;
                this.masv = masv;
            }

        }

        public bool checknull()
        {
            if(txtHoten.Text =="" || txtMaSV.Text =="" || cbGioitinh.Text == "" || txtLop.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
                return false;
            }
           return true;
        }

        public static string chuanhoa(string str)
        {
            string res = str.Trim();
            while(res.Contains("  ") == true)
            {
                res = str.Replace("  ", " ");
            }
            res = res.ToLower();
            string []arrWord =  res.Split(' ');
            res = string.Empty;
            foreach(var word in arrWord)
            {
                string strWord = word.Substring(0, 1).ToUpper() + word.Substring(1);
                res += strWord + " ";
            }
            res = res.TrimEnd();
            return res;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            if (checknull())
            {
               string name = chuanhoa(txtHoten.Text),
                gioitinh = cbGioitinh.Text,
                ngaysinh = dtpNgaysinh.Text,
                diachi = txtDiachi.Text,
                lop = txtLop.Text;

                int masv = Int32.Parse(txtMaSV.Text);
                SinhVien st = new SinhVien(name, masv, gioitinh, ngaysinh, lop, diachi);
                list.Add(st);
                dgvViewport.DataSource = null;
                dgvViewport.DataSource = list;
                dgvViewport.Refresh();
            }
            
        }
        int index;
        private void dgvViewport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                txtHoten.Text = list[index].name;
                txtMaSV.Text = list[index].masv.ToString();
                cbGioitinh.Text = list[index].gioitinh.ToString();
                dtpNgaysinh.Text = list[index].ngaysinh.ToString();
                txtLop.Text = list[index].lop.ToString();   
                txtDiachi.Text = list[index].diachi.ToString();
            }
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                list[index].name = chuanhoa(txtHoten.Text);
                list[index].masv = Int32.Parse(txtMaSV.Text);
                list[index].gioitinh = cbGioitinh.Text;
                list[index].ngaysinh = dtpNgaysinh.Text;
                list[index].lop = txtLop.Text;
                list[index].diachi = txtDiachi.Text;
                dgvViewport.DataSource = null;
                dgvViewport.DataSource = list;
            }
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                list.RemoveAt(index);
                dgvViewport.DataSource = null;
                dgvViewport.DataSource = list;
            }
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            string v = txtTimKiem.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(v))
            {
                dgvViewport.DataSource = null;
                dgvViewport.DataSource = list;
                List<SinhVien> tmp = new List<SinhVien>();
                foreach (SinhVien sv in list)
                {
                    if (FuzzySearch(sv.name.ToLower(), v)) // Kiểm tra xem tên học sinh tương tự với nội dung tìm kiếm
                    {
                        tmp.Add(sv);
                    }
                }
                dgvViewport.DataSource = null;
                dgvViewport.DataSource = tmp;
            }
            else
            {
                dgvViewport.DataSource = null;
                dgvViewport.DataSource = list;
            }
        }

        private bool FuzzySearch(string input, string searchText)
        {
            // Thực hiện tìm kiếm gần đúng ở đây, bạn có thể sử dụng các thuật toán tìm kiếm chuỗi phù hợp với yêu cầu của bạn
            // Ví dụ đơn giản: Kiểm tra xem tên học sinh có chứa từ khóa tìm kiếm
            return input.Contains(searchText);
        }

        // bắt lỗi
        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
