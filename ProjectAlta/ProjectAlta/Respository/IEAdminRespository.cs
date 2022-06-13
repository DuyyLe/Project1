using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Data;
using ProjectAlta.Entity;
namespace ProjectAlta.Respository
{
    public interface IEAdminRespository
    {
        List<Admin> GetAll();
        Admin GetById(int teacherId);
        void Insert(Admin admin);
        void Update(Admin admin);
        void Delete(int teacherId);
        void Save();
    }
}
