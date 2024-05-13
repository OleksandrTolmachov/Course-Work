using System.Collections.Generic;
using System.Linq;

namespace CourseWork
{
    public class ShopManager : IShopManager
    {
        private HashSet<BaseItem> _productToQuantity = new HashSet<BaseItem>();
        private int _idProductCounter = 0;

        public void AddProduct(BaseItem item)
        {
            _productToQuantity.Add(item);
        }

        public IReadOnlyCollection<BaseItem> GetProductsToQuantity()
        {
            return _productToQuantity;
        }

        public IReadOnlyCollection<BaseItem> GetProductByIds(params int[] ids)
        {
            HashSet<BaseItem> requiredProducts = new HashSet<BaseItem>();

            for (int i = 0; i < _productToQuantity.Count; i++)
            {
                var product = _productToQuantity.ElementAt(i);
                if (ids.Contains(product.Id))
                {
                    requiredProducts.Add(product);
                }
            }

            return requiredProducts;
        }

        public int GetAvailableProductId()
        {
            return _idProductCounter++;
        }

        public void RemoveProduct(int itemId)
        {
            _productToQuantity.RemoveWhere(item => item.Id == itemId);
        }
    }
}
