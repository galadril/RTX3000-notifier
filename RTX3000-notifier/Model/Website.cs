﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RTX3000_notifier.Model
{
    public interface IWebsite
    {
        public string Url { get; set; }

        public Stock GetStock();
    }
}