using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProjectAlta.DTO;
using ProjectAlta.Entity;
namespace ProjectAlta.Respository
{
    public interface IEAdminRespository
    {
        List<AdminDTO> GetAll();
        AdminDTO GetById(string teacherId);
        bool Insert(AdminDTO admin);
        bool Update(AdminDTO admin);
        bool Delete(string teacherId);
        void Save();
    }
}
