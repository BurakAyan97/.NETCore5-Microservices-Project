﻿using FreeCourse.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    public class OrderItem : Entity
    {
        public string ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
        public decimal Price { get; private set; }

        //Order Id eklemiyoruz navigation property kullanmıyoruz DDD tasarlarken. EF Core kendisi ayarlıyor.Inherit veriyoruz o zaten içinde hazır kodlar yapıştırdık. Diğer bir sebebi dışarıdan OrderId kullanılarak OrderItem eklenebiliyor databaseye. Bunu istemiyoruz.
        //Shadow property : Veritabanında bir sütun olarak olan ama entity içerisinde bir porperty olarak karşılığı olmayan yapılardır.
        public OrderItem(string productId, string productName, string pictureUrl, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
        public OrderItem()
        {
            
        }

        public void UpdateOrderItem(string productName, string pictureUrl, decimal price)
        {
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
    }

}
