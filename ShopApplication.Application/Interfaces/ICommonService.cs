﻿using System;
using System.Collections.Generic;
using System.Text;
using ShopApplication.Application.ViewModels.Common;

namespace ShopApplication.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
