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
    public partial class FormDate : Form
    {
        public Product Product { get; set; }
        public DateTime SelectedDate { get; private set; }

        public FormDate(Product product)
        {
            InitializeComponent();
            this.Product = product;
            this.Text = ($"Выбор даты поступления: {product.Name}");
            dateTimePickerReceived.Value = DateTime.Today; 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedDate = dateTimePickerReceived.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
