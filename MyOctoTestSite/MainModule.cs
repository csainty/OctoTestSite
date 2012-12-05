using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace MyOctoTestSite
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = p => "Hello World";
        }
    }
}