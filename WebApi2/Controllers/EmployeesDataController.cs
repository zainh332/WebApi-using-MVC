﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2.Controllers
{
    public class EmployeesDataController : ApiController
    {
        
        public string[] employeesdata = {"zain", "usama", "adil"};

        public string[] getemployee()
        {
            return employeesdata;
        }

        public string getemployessdata(int id)
        {
            return employeesdata [id];
        }
    }
}
