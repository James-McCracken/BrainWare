using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    using System.Web.Mvc;
    using Infrastructure;
    using Models;

    public class OrderController : ApiController
    {
        [HttpGet]
        public IEnumerable<Order> GetOrders(int id = 1)
        {

            var data = new OrderService().GetOrdersForCompany(id);
            if (data == null)
            {
                return new List<Order>
                {
                    new Order {
                        Description = "Error. No data returned from database."
                    }
                };

            }
            return data;
        }
    }
}
