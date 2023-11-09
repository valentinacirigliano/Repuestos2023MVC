﻿using Repuestos2023.DataLayer.Data;
using Repuestos2023.DataLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos2023.DataLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Categorias = new CategoryRepository(_db);
            Proveedores = new SupplierRepository(_db);
            Repuestos = new RepuestoRepository(_db);
            Ciudades = new CityRepository(_db);
            Provincias = new ProvinceRepository(_db);
        }

        public ICategoryRepository Categorias { get; private set; }
        public ISupplierRepository Proveedores { get; private set; }
        public IRepuestoRepository Repuestos { get; private set; }
        public ICityRepository Ciudades { get; private set; }
        public IProvinceRepository Provincias { get; private set; }

        public void BeginTransaction()
        {
            _db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _db.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _db.Database.RollbackTransaction();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }

}
