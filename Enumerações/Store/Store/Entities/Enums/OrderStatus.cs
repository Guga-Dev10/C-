using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 3,
        Delivered = 4
    }
}
