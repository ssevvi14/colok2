using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductWareHouse
{
    public partial class FormStore : Form
    {
        private readonly List<Product> availableProducts = new List<Product>
    {
        new Product("Молоко", 5),
        new Product("Йогурт", 3),
        new Product("Мясо", 2),
        new Product("Рыба", 3),
        new Product("Салат", 1)
    };

        private List<StoredProduct> storedProducts = new List<StoredProduct>();

        public FormStore()
        {
            InitializeComponent();
            FillProductsList(); 
            RefreshStoredList(); 
        }

        private void FillProductsList()
        {
            listBoxProducts.DataSource = null;
            listBoxProducts.DataSource = availableProducts;
        }

        private void RefreshStoredList()
        {
            listBoxStored.DataSource = null;
            listBoxStored.DataSource = storedProducts;
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is Product selectedProduct)
            {
                using (var formDate = new FormDate(selectedProduct))
                {
                    if (formDate.ShowDialog() == DialogResult.OK)
                    {
                        var storedProduct = new StoredProduct(selectedProduct, formDate.SelectedDate);
                        storedProducts.Add(storedProduct);
                        RefreshStoredList();
                    }
                }
                listBoxProducts.ClearSelected(); 
            }
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
                    storedProducts = storedProducts.Where(p => p.IsExpiredOrNear).ToList();
                    RefreshStoredList();
        }
    }
}

