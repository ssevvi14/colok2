using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWareHouse
{
    public class StoredProduct
    {

        public Product Product { get; set; }
        public DateTime DateReceived { get; set; }

        public StoredProduct(Product product, DateTime dateReceived)
        {
            Product = product;
            DateReceived = dateReceived;
        }

        public DateTime ExpirationDate => DateReceived.AddDays(Product.ShelfLifeDays);
        public int DaysUntilExpiration => (ExpirationDate - DateTime.Today).Days;
        public bool IsExpiredOrNear => DaysUntilExpiration <= 3;

        public override string ToString() =>
            $"{Product.Name} | Поступление: {DateReceived.ToShortDateString()} | Годен до: {ExpirationDate.ToShortDateString()} | Осталось: {DaysUntilExpiration} дн.";
    }
      
}
