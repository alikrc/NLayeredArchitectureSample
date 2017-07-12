using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayeredArchitectureSample.Model;

namespace NLayeredArchitectureSample.Service
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(int id);
    }
}
