﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        public virtual long Id { get; set; }
        [StringLength(155)]
        public virtual string Description { get; set; }
    }
}