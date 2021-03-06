﻿using System;
using System.Linq;
using Cedro.Application.Interfaces;
using Cedro.Domain.Interfaces.Services;

namespace Cedro.Application.Services
{
    public class AppServiceBase<TEntity> :  IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);

        }

        public IQueryable<TEntity> Get()
        {
            return _serviceBase.Get();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

  
    }
}
