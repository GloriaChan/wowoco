﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ecards.Pages
{
    public class My_First_PageModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {

        }
    }
}
