﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayeredArchitectureSample.Model;

namespace NLayeredArchitectureSample.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {

        }

        public override IEnumerable<Person> GetAll()
        {
            return _entities.Set<Person>().Include(x => x.Country).AsEnumerable();
        }

        public Person GetById(long id)
        {
            return _dbset.Include(x => x.Country).FirstOrDefault(x => x.Id == id);
        }
    }
}
