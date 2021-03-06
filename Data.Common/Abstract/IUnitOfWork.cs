﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        ICountryRepository CountryRepository { get; }
        ICurrencyRepository CurrencyRepository { get; }
        IOrganizationRepository OrganizationRepository { get; }
        void Complete();
        Task CompleteAsync();
    }
}
