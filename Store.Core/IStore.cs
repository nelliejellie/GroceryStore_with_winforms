using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{
    public interface IStore : IStoreManager, IStoreStaff
    {

    }
    public interface IStoreManager
    {
        List<Product> Products { get; set; }
        double VAT { get; }
        void AddToProduct(string id, int numberChange);
        string CreateProduct(string nameOfProduct, int quantity = 0);
        void DeleteProduct(string Id);
        void SetVAT(double newVAT);
        void UpdateProductPrice(string id, decimal newPrice);
    }

    public interface IStoreStaff
    {
        void RemoveFromProduct(string id, int numberChange);
        Product GetProduct(string id);
    }

}
