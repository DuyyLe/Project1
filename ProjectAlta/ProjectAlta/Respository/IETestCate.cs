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
    public interface IETestCate
    {
        List<TestCateDTO> GetAll();
        TestCateDTO GetById(int testCateId);
        bool Insert(TestCateDTO testCate);
        bool Update(TestCateDTO testCate);
        bool Delete(int testCateId);
        void Save();
    }
}
