using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sapo.Models;

namespace Sapo.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private ISapoRepository repo { get; set; }

        public TypesViewComponent (ISapoRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
                

            return View(types);
        }

    }
}
