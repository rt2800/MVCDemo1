using System;
using System.Web.Mvc;
using System.Web;
using System.IO;

namespace WebApplication2.Views
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlString PrettyRatings(int ratings)
        {
            Func<int, string> rating = p =>
            {
                string s = "<span class='star-rating'>";
                using (var w = new StringWriter())
                {
                    int i = 0;              
                    while (i < p){
                        s += @"<span class='glyphicon glyphicon-star'></span>";
                        i++;
                    }
                    while (i < 5)
                    {
                        s += @"<span class='glyphicon glyphicon-star-empty'></span>";
                        i++;
                    }
                    s += "</span>";
                }
                return s;                
            };            
            return new HtmlString(rating(ratings));
        }

    }
}