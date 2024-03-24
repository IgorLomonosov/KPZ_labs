﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02Library
{
    public class DeviceFactory
    {
        public IDevice CreateDevice(string type, string brand)
        {
            switch(type.ToLower())
            {
                case "laptop":
                    return new Laptop(brand);
                case "netbook":
                    return new Netbook(brand);
                case "ebook":
                    return new EBook(brand);
                case "smartphone":
                    return new Smartphone(brand);
                default:
                    return null;
            }
        }
    }
}
