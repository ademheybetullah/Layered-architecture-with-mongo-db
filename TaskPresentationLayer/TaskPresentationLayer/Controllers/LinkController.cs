﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskPresentationLayer.Controllers
{
    public class LinkController : ApiController
    {
        LinkBusiness linkBusiness = new LinkBusiness();
        public List<NewLink> Links()
        {
            List<NewLink> gelenLink = linkBusiness.GetLink("Android");
            return gelenLink;
        }
    }
}
