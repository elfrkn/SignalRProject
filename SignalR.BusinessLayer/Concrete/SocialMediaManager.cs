﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia entity)
        {
           _socialMediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
           _socialMediaDal.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
           return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetAllList()
        {
            return _socialMediaDal.GetAllList();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
