﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Entity;
using System.Web.Mvc;

namespace ECommerceSample.Areas.Admin.Models.ViewModel
{
    public class ProductViewModel
    {
        public Product Product{ get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> BrandList { get; set; }
    }
}