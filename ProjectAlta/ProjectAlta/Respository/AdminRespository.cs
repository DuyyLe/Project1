using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;
using AutoMapper;
using ProjectAlta.DTO;
namespace ProjectAlta.Respository
{
    public class AdminRespository : IEAdminRespository
    {
        private readonly IMapper admap;
        private readonly Context con;

        
        public AdminRespository(Context context,IMapper mapper)
        {
            con = context;
            admap = mapper;
        }

        public bool Delete(string teacherId)
        {
            var DeleteAd = con.Admins.Find(teacherId);
            if (DeleteAd == null)
            {
                return false;
            }
            con.Remove(DeleteAd);
            return true;
        }

        public List<AdminDTO> GetAll()
        {
           var allAd = con.Admins.ToList();
            return admap.Map<List<AdminDTO>>(allAd);
            
        }

        public AdminDTO GetById(string teacherId)
        {
            var byid = con.Admins.Find(teacherId);
            if(byid == null)
            {
                return null;
            }
                
            return admap.Map<AdminDTO>(byid);
        }

        public  bool Insert(AdminDTO admin)
        {
            var insertAd = con.Admins.Find(admin.teacherId);
            if(insertAd == null)
            {
                con.Admins.Add(admap.Map<Admin>(admin));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(AdminDTO admin)
        {
            var UpdateAd = con.Admins.Find(admin.teacherId);
            if (UpdateAd != null)
            {
                con.Admins.Update(admap.Map(admin,UpdateAd));
                return true;
            }
            return false;
        }

       
    }
}
