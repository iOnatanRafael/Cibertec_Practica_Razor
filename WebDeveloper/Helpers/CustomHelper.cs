using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {

        public static IHtmlString DisplayEmptyExtension(this HtmlHelper helper, string empty)
        {
            return new HtmlString(GetHtmlForPrice(empty));
        }

        private static string GetHtmlForPrice(string empty)
        {
            return empty == "" ? "<span>No data!!!</span>" : $"<span>{ empty }</span>";
        }

  
    }
}
