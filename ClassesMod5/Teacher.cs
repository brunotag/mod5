﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }


        public Teacher(string first, string last, string subject)
        {
            FirstName = first;
            LastName = last;
            Subject = subject;
        }
    }
}
