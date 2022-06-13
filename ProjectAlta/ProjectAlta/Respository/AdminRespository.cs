using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Data;
using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;
namespace ProjectAlta.Respository
{
    public class AdminRespository : IEAdminRespository
    {
        private readonly Context con;


        public AdminRespository(Context context)
        {
            con = context;
        }

        public void Delete(int teacherId)
        {
            Admin admin = con.Admins.Find(teacherId);
            con.Admins.Remove(admin);
        }

        public List<Admin> GetAll()
        {
            return con.Admins.ToList();
        }

        public Admin GetById(int teacherId)
        {
            return con.Admins.Find(teacherId);
        }

        public void Insert(Admin admin)
        {
            con.Admins.Add(admin);
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public void Update(Admin admin)
        {
            con.Entry(admin).State = EntityState.Modified;
        }
    }
}
