using System.Web;
using System.Web.Mvc;
using Contoso.MVC.Filters;

namespace Contoso.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ContosoExceptionFilter());
            // for whole application
        }
    }
}
