﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IGenericRepository<T>
    {
        Task<T> GetByIdAsync(int id);

    }
}
