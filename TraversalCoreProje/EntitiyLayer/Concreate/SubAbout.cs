﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concreate
{
    public class SubAbout
    {
        [Key]
        public int SubAboutıD { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
