﻿using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<App> Apps = AppList.ToList();

        public void OnGet()
        {
        }





}
}