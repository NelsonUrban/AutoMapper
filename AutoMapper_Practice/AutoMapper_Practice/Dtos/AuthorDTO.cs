﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Practice.Dtos
{
    public class AuthorDTO
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
        public string Address
        {
            get; set;
        }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}
