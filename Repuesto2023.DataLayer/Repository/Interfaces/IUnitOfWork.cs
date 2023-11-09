﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos2023.DataLayer.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categorias { get; }
        ISupplierRepository Proveedores { get; }
        IRepuestoRepository Repuestos { get; }
        ICityRepository Ciudades { get; }
        IProvinceRepository Provincias { get; }
        void Save();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
