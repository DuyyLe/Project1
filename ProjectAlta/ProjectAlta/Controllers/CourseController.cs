﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;

using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;
using AutoMapper;
using ProjectAlta.DTO;
namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private IECourseRespository _CourseRespo;
        private IMapper coursemap;
        public CourseController(IECourseRespository courserespo,IMapper mapper)
        {
            coursemap = mapper;
            _CourseRespo = courserespo;
        }
        [HttpGet]
        public async Task<ActionResult<List<CourseDTO>>> getAllCourse()
        {
            var model = _CourseRespo.GetAll();
            if (model == null)
            {
                return new List<CourseDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddCourse(CourseDTO model)
        {
            var check = _CourseRespo.Insert(model);
            _CourseRespo.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateCourse(CourseDTO model)
        {
            var check = _CourseRespo.Update(model);
            _CourseRespo.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCourse(int id)
        {
            var check = _CourseRespo.Delete(id);

            _CourseRespo.Save();
            return check;

        }
    }
}
