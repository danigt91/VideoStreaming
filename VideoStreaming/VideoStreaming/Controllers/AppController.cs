﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStreaming.Models.App;

namespace VideoStreaming.Controllers
{
    public class AppController : Controller
    {

        public PartialViewResult MenuPublico()
        {

            var enlaces = new List<EnlaceViewModel>();
            enlaces.Add(new EnlaceViewModel()
            {
                Url = URLDecode("Index", "Home", new { area = "" }),
                Texto = "Home"
            });
            enlaces.Add(new EnlaceViewModel()
            {
                Url = URLDecode("Index", "Video", new { area = "" }),
                Texto = "Video Streamming"
            });

            return PartialView("_MenuPublic", enlaces);
        }

        private string URLDecode(string action, string controller, object attributes = null)
        {
            var url = "";
            if (attributes != null)
                url = Url.Action(action, controller, attributes);
            else
                url = Url.Action(action, controller);
            url = HttpUtility.UrlDecode(url);
            return url;
        }

    }
}