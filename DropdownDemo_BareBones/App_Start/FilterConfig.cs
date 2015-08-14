using System.Web;
using System.Web.Mvc;

namespace DropdownDemo_BareBones
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}