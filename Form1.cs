using hoangdhph31492_Csharp3_BT2._2.CONTROLLER;
using hoangdhph31492_Csharp3_BT2._2.MODEL.DomainClass;

namespace hoangdhph31492_Csharp3_BT2._2
{
    public partial class Form1 : Form
    {
        SachRespository _respo = new SachRespository();
        SachService _service = new SachService();
        string _maSachClick;
        Guid _IdWhenClick;
        public Form1()
        {
            InitializeComponent();
            loadNXB();
            loadGridView(null);
        }
        public void loadNXB()
        {
            var data = _respo.GetNxbs().ToList();
            cmbNXB.DataSource = data;
            cmbNXB.DisplayMember = "Nxb1";
            cmbNXB.ValueMember = "Id";
        }
        public void loadGridView(string input)
        {
            int stt = 1;
            Type type = typeof(Sach);
            dtgSach.ColumnCount = type.GetProperties().Length + 1;
            dtgSach.Columns[0].Name = "Stt";
            dtgSach.Columns[1].Name = "Mã sách";
            dtgSach.Columns[2].Name = "Tên Sách";
            dtgSach.Columns[3].Name = "NXB";
            dtgSach.Columns[4].Name = "Trạng Thái";
            foreach (var s in _respo.GetSaches(input))
            {
                dtgSach.Rows.Add(stt++, s.Ma, s.Ten, s.IdNxb == null ? "buôn lậu" : _respo.GetTenNxb((Guid)s.IdNxb).Nxb1, s.Tt == true ? "Còn Hàng" : "Hết Hàng");
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach obj = new Sach();
            obj.Ma = txtMa.Text;
            obj.Ten = txtTen.Text;
            if (rbtCH.Checked)
            {
                obj.Tt = true;
                rbtHH.Checked = false;
            }
            if (rbtHH.Checked)
            {
                obj.Tt = false;
                rbtCH.Checked = false;
            }
            obj.IdNxb = Guid.Parse(cmbNXB.SelectedItem.ToString());
            _service.ThemSach(obj);
            loadGridView(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach obj = new Sach();
            obj.Ma = txtMa.Text;
            obj.Ten = txtTen.Text;
            if (rbtCH.Checked)
            {
                obj.Tt = true;
                rbtHH.Checked = false;
            }
            if (rbtHH.Checked)
            {
                obj.Tt = false;
                rbtCH.Checked = false;
            }
            obj.IdNxb = Guid.Parse(cmbNXB.SelectedItem.ToString());
            obj.Id = _IdWhenClick;
            _service.SuaSach(obj);
            loadGridView(null);
        }

        private void dtgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= dtgSach.Rows.Count || rowIndex < 0)
            {
                return;
            }
            else
            {
                _maSachClick = dtgSach.Rows[rowIndex].Cells[1].Value.ToString();
            }
            var obj = _respo.GetSaches(null).FirstOrDefault(s => s.Ma == _maSachClick);
            txtMa.Text = obj.Ma; txtTen.Text = obj.Ten;
            if (obj.Tt == true)
            {
                rbtCH.Checked = true;
            }
            else
            {
                rbtHH.Checked = true;
            }
            cmbNXB.SelectedItem = _respo.GetTenNxb((Guid)obj.IdNxb);
            _IdWhenClick = obj.Id;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            loadGridView(txtTim.Text);
        }
    }
}