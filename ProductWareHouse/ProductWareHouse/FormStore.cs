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

        private List<StoredProduct> storedProducts;

        private readonly List<Product> availableProducts = new List<Product>
        {
            new Product("Молоко", 3),
            new Product("Йогурт", 5),
            new Product("Мясо", 2),
            new Product("Рыба", 1),
            new Product("Салат", 1)
        };

        public FormStore()
        {
            InitializeComponent();
            storedProducts = new List<StoredProduct>();
            FillProductsList();
            RefreshStoredList();
        }

        private void FillProductsList()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in availableProducts)
                listBoxProducts.Items.Add(product);
        }

        private void RefreshStoredList()
        {
            listBoxStored.Items.Clear();
            foreach (var item in storedProducts)
                listBoxStored.Items.Add(item.ToString());
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is Product selectedProduct)
            {
                using (var dateForm = new FormDate(selectedProduct))
                {
                    if (dateForm.ShowDialog() == DialogResult.OK)
                    {
                        var stored = new StoredProduct(selectedProduct, dateForm.SelectedDate);
                        storedProducts.Add(stored);
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

        private void FormStore_Load(object sender, EventArgs e)
        {

        }
    }
}

