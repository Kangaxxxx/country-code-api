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
        public string GetUrl { get; set; }
    }

    public class CountryDetailsDTO: CountryDTO
    {
        public string PutUrl { get; set; }
        public string DeleteUrl { get; set; }
        public string PostCurrencyUrl { get; set; }

        public int? CallingCode { get; set; }
        public string DateFormat { get; set; }
        public IEnumerable<CurrencyDTO> Currencies { get; set; }
        public IEnumerable<OrganizationDTO> Organizations { get; set; }
    }
}