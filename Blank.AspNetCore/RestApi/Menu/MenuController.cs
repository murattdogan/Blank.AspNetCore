﻿using Blank.AspNetCore.Abstract;
using Blank.AspNetCore.Abstract.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blank.AspNetCore.RestApi
{
    [Route("api/[controller]/[action]")]
    public class MenuController : Controller
    {
        IMenuBuilder _menuBuilder;
        public MenuController(IMenuBuilder menuBuilder)
        {
            _menuBuilder = menuBuilder;
        }
        
        [HttpGet("")]
        public MainMenu Index()
        {
            var mainMenu=_menuBuilder.GetMenu();
            return mainMenu;
        }
    }
}