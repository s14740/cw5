﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw5.Models
{
    public class Student
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime Birthdate { get; set; }
        
        public string Studies { get; set; }
        public int Semester { get; set; }

    }
}
