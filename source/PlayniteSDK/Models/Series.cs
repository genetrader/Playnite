﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.SDK.Models
{
    public class Series : DatabaseObject
    {
        public Series() : base()
        {
        }

        public Series(string name) : base()
        {
            Name = name;
        }

        public static readonly Series Empty = new Series { Id = Guid.Empty, Name = string.Empty };
    }
}