﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwartz_hoseynzadeh2
{
    class Lesson
    {
        // 0 to 4, saturday to wednesday
        public int Whichday;
        public int NumberOfClassmates  =0;
        //public int Capacity;
        public string Name;
        public Teacher TeaacherOfCource = new Teacher();
    }
}
