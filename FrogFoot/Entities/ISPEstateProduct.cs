﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FrogFoot.Entities
{
    public class ISPEstateProduct
    {
        public int ISPEstateProductId { get; set; }

        public int ISPProductId { get; set; }
        public ISPProduct ISPProduct { get; set; }

        public int ISPId { get; set; }
        public ISP ISP { get; set; }

        public int EstateId { get; set; }
        public Estate Estate { get; set; }
    }
}