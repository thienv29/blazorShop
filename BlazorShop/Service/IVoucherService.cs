﻿using BlazorShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorShop.Service
{
    public interface IVoucherService
    {
        IEnumerable<Voucher> getAllVouchers();
        
    }
}
