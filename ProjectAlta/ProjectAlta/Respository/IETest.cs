using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProjectAlta.Entity;
using ProjectAlta.DTO;
namespace ProjectAlta.Respository
{
    public interface IETest
    {
        List<TestDTO> GetAll();
        TestDTO GetById(int testId);
        bool Insert(TestDTO test);
        bool Update(TestDTO test);
        bool Delete(int testId);
        void Save();
    }
}
