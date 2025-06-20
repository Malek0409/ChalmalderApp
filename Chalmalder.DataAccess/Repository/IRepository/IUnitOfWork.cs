﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chalmalder.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRepositoryCategory Category { get; }
        IRepositoryProduct Product { get; }
        void Save();
    }
}
