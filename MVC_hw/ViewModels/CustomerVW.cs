﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_hw.ViewModels
{
    public class CustomerVW
    {
        public int Id { get; set; }
        public string 客戶名稱 { get; set; }
        public int 聯絡人數量 { get; set; }
        public int 銀行帳戶數量 { get; set; }
    }
}