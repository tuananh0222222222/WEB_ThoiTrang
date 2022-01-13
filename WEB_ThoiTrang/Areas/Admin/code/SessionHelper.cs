using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_ThoiTrang.Areas.Admin.code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession section)
        {
            HttpContext.Current.Session["LoginSession"] = section;
        }
        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["LoginSession"];
            if(session == null)
            {
                return null;

            }else
            {
                return session as UserSession;
            }
        }
    }
}