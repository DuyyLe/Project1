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
    public interface IEStudentTest
    {
        List<StudentTestDTO> GetAll();
        StudentTestDTO GetById(int studentTestId);
        bool Insert(StudentTestDTO studentTest);
        bool Update(StudentTestDTO studentTest);
        bool Delete(int studentTestId);
        void Save();
    }
}
