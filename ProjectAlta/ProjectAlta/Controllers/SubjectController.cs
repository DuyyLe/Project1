using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
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
    public class SubjectController : ControllerBase
    {
        private IESubject _subject;
        private IMapper map;

        public SubjectController(IESubject subject, IMapper mapper)
        {
            map = mapper;
            _subject = subject;
        }

        [HttpGet]
        public async Task<ActionResult<List<SubjectDTO>>> getsub()
        {
            var model = _subject.GetAll();
            if (model == null)
            {
                return new List<SubjectDTO>();
            }
            return model.ToList();
        }

        [HttpPost]
        public ActionResult<bool> AddSub(SubjectDTO model)
        {
            var check = _subject.Insert(model);
            _subject.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateTest(SubjectDTO model)
        {
            var check = _subject.Update(model);
            _subject.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTest(int id)
        {
            var check = _subject.Delete(id);

            _subject.Save();
            return check;

        }
    }
}
