﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDesktopUILibrary.Models;

namespace TRMDesktopUILibrary.Api
{
    public interface IProductEndPoint
    {
        Task<List<ProductModel>> GetAll();
    }
}