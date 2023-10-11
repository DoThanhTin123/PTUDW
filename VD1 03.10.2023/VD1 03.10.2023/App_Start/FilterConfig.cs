using System.Web;
using System.Web.Mvc;

namespace VD1_03._10._2023
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
