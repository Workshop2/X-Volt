﻿using System.Collections.Generic;
using System.Linq;
using Xvolt.Domain.Models;
using Xvolt.Domain.Repositories;

namespace Xvolt.Domain.Data.Repositories
{
    public class ImageRepository : RepositoryBase, IImageRepository
    {
        public Image Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Image> List()
        {
            throw new System.NotImplementedException();
        }

        public void Save(Image user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Image user)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}