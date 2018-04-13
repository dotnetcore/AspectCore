﻿using System;
using System.Threading.Tasks;

namespace AspectCore.Extensions.Windsor.Test.Fakes
{
    public class CacheService : ICacheService
    {
        public Model Get(int id)
        {
            return new Model { Id = id, Version = Guid.NewGuid() };
        }

        public Task<Model> GetAsync(int id)
        {
            return Task.FromResult(Get(id));
        }
    }
}
