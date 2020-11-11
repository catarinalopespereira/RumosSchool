using RumosSchool.Model.Model;
using RumosSchool.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumosSchool.WinForms
{
    public partial class Form1 : Form
    {

        private ProductService _service;

        public Form1()
        {
            InitializeComponent();
            _service = new ProductService();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text.Trim();
            decimal uniPrice = decimal.Parse(unitPriceTxt.Text);

            Product product = new Product()
            {
                Name = name,
                UnitPrice = uniPrice
            };


            try
            {
                _service.Add(product);
                MessageBox.Show("Product saved with id: " + product.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
