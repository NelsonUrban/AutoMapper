﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Practice.Models
{
    public class AuthorModel
    {
     
            public int Id
            {
                get; set;
            }
            public string FirstName
            {
                get; set;
            }
            public string LastName
            {
                get; set;
            }
        public Address Address
        {
            get; set;
        }

    }
}
