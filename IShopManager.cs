using System.Collections.Generic;

namespace CourseWork
{
    public interface IShopManager
    {
        void AddProduct(BaseItem item);
        IReadOnlyCollection<BaseItem> GetProductsToQuantity();
        IReadOnlyCollection<BaseItem> GetProductByIds(params int[] ids);
        int GetAvailableProductId();
        void RemoveProduct(int itemId);
    }
}
