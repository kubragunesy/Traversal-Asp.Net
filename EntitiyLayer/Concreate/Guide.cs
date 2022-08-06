﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concreate
{
    public class Guide
    {
        [Key]
        public int GuideID { get; set; }
        public string GuideName { get; set; }
        public string Description { get; set; }           
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramrUrl { get; set; }
        public bool Status { get; set; }


    }
}
