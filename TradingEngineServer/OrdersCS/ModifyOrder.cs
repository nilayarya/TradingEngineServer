using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class ModifyOrder : IOrderCore
    {
        public ModifyOrder(IOrderCore orderCore, long modifyPrice, uint modifyQuantity, bool isBuySide)
        {
            Price = modifyPrice;
            Quantity = modifyQuantity;
            IsBuySide = isBuySide;
            _orderCore= orderCore;
        }

        public long Price { get; set; }
        public uint Quantity { get; set; }
        public bool IsBuySide { get; set; }
        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;


        public CancelOrder ToCancelOrder()
        {
            return new CancelOrder(this);
        }

        public Order ToNewOrder()
        {
            return new Order(this);
        }


        private readonly IOrderCore _orderCore;
    }
}
