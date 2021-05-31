﻿using Flattener.Attributes;
using Flattener.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Models
{
    [Flatten]
    public class DuplicateOffset
    {

        [Flat(Offset = 1, Length = 25)]
        public string Offset01 { get; set; }
        [Flat(Offset = 1, Length = 15, Justified = Justified.RIGHT)]
        public string Offset02 { get; set; }
    }
}