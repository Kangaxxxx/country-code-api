﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.API.Models
{
    public class CountryDTO
    {
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public int? CallingCode { get; set; }
    }

    public class CountryDetailsDTO: CountryDTO
    {
        public IEnumerable<CurrencyDTO> Currencies { get; set; }
    }
}