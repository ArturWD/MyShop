using MyShop.Core.Models;
using MyShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Contracts
{
    public interface IOrderService
    {
        void UpdateOrder(Order updatedorder);
        Order GetOrder(string Id);
        List<Order> GetOrderList();
        void CreateOrder(Order baseorder, List<BasketItemViewModel> basketItems);
    }
}
