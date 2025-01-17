﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopApplication.Application.Dapper.ViewModels;

namespace ShopApplication.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}
