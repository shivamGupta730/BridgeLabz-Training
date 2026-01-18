using System;

namespace basic.FlashDealz
{
    internal class ProductMenu
    {
        public void Show()
        {
            ProductUtility utility = new ProductUtility(5);

            utility.AddDiscount();
            utility.Sort();
            utility.Display();
        }
    }
}
