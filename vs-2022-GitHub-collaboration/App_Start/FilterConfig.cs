using System.Web;
using System.Web.Mvc;

namespace vs_2022_GitHub_collaboration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
