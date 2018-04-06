using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUIVueJs.ViewComponents
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {

            return Task.FromResult<IViewComponentResult>(View());
        }
    }
}
