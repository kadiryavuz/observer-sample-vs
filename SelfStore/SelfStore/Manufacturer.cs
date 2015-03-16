using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerProject
{
    /// <summary>
    /// Subject abstract class
    /// </summary>
    abstract class Manufacturer
    {


        private List<IDistributer> _distributers = new List<IDistributer>();
        public UpdateType _actionType = UpdateType.None;

        public Manufacturer(string p_name)
        {
            this.Name = p_name;
            this._products = LoadProducts();
        }

        public string Name { get; set; }

        private List<Product> _products;
        public List<Product> Products
        {
            get
            {
                if (_products == null)
                    _products = new List<Product>();

                return _products;
            }
            set
            {
                _products = value;
            }
        }

        public abstract List<Product> LoadProducts();

        public void Attach(IDistributer p_distributer)
        {
            if (!_distributers.Contains(p_distributer))
                _distributers.Add(p_distributer);
        }

        public void Detach(IDistributer p_distributer)
        {
            if (_distributers.Contains(p_distributer))
                _distributers.Remove(p_distributer);
        }

        public void Notify(Product p_product)
        {
            foreach (IDistributer distributer in _distributers)
            {
                distributer.Update(this, p_product);
            }
        }

        public void ChangePrice(int id, double price)
        {
            Product a = Products.Find(x => x.ID == id);
            if (a != null && !Double.Equals(a.Price, price))
            {
                a.Price = price;
                this._actionType = UpdateType.PriceChanged;
                this.Notify(a);
            }

        }

        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
                this._actionType = UpdateType.NewProduct;
                Notify(product);
            }
        }
    }
    public enum UpdateType
    {
        None,
        NewProduct,
        PriceChanged
    }
}
