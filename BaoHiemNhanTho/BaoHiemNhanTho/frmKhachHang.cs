using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaoHiemNhanTho
{
    public partial class frmKhachHang : Form
    {
        private IMongoCollection<Customer> _customerCollection;

        public frmKhachHang()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("BHNT");
            _customerCollection = database.GetCollection<Customer>("BaoHiemNhanTho");
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // Lấy tất cả khách hàng từ MongoDB
            var customers = _customerCollection.Find(_ => true).ToList();

            // Chuyển danh sách khách hàng vào DataGridView
            dgvDSKhachHang.DataSource = customers.Select(c => new
            {
                CustomerId = c.CustomerId,
                FullName = c.Name.FirstName + " " + c.Name.LastName,
                Gender = c.Gender,
                Phone = c.PhoneNumber,
                Email = c.Email,
                Address = c.Address.Street + ", " + c.Address.City + ", " + c.Address.Country
            }).ToList();
        }
    }
}
