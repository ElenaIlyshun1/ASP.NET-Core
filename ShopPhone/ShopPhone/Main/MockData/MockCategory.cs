﻿using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.MockData
{
    public class MockCategory : IPhoneCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>{
                    new Category { categoryName = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                    new Category { categoryName = "Budget", categoryDescription = "Phone with low price without extra fubctions" }
                };
            }
        }
    }
}
