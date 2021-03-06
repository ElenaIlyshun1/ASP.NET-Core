﻿using Microsoft.AspNetCore.Mvc;
using ShopPhone.Main.Interfaces;
using ShopPhone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Controllers
{
    public class SsdController : Controller
    {
        private readonly IAllSsd _allSsd;
        private readonly ISsdCategory _allSsdCategories;

        public SsdController(IAllSsd iallSsd, ISsdCategory iSsdCategory)
        {
            _allSsd = iallSsd;
            _allSsdCategories = iSsdCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Ssd";
            SsdListViewModel obj = new SsdListViewModel();
            obj.allSsds = _allSsd.ssds;
            obj.currentCategory = "Ssd : ";

            return View(obj);
        }
    }
}
