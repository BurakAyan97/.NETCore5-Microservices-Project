using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeCourse.Web.Models.Baskets
{
    public class BasketViewModel
    {
        public string UserId { get; set; }
        public string DiscountCode { get; set; }
        public int? DiscountRate { get; set; }
        private List<BasketItemViewModel> _basketItems { get; set; }

        public List<BasketItemViewModel> BasketItems
        {
            get
            {
                if (HasDiscount)
                {
                    //Örnek kurs fiyat 100 tl indirim oranı %10
                    _basketItems.ForEach(b =>
                    {
                        var discountPrice = b.Price * ((decimal)DiscountRate.Value / 100);
                        b.AppliedDiscount(Math.Round(b.Price - discountPrice, 2));//90.00
                    });
                }
                return _basketItems;
            }
            set { _basketItems = value; }
        }

        public decimal TotalPrice
        {
            get => BasketItems.Sum(x => x.GetCurrentPrice);
        }

        public bool HasDiscount
        {
            get => !string.IsNullOrEmpty(DiscountCode);
        }
    }
}
