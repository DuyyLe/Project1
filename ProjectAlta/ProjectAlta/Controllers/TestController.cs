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
    public class TestController : ControllerBase
    {
        private IETest _test;
        private IMapper testmap;

        public TestController(IETest test, IMapper mapper)
        {
            testmap = mapper;
            _test = test;
        }


        [HttpGet]
        public async Task<ActionResult<List<TestDTO>>> gettestcate()
        {
            var model = _test.GetAll();
            if (model == null)
            {
                return new List<TestDTO>();
            }
            return model.ToList();
        }

        [HttpPost]
        public ActionResult<bool> AddTest(TestDTO model)
        {
            var check = _test.Insert(model);
            _test.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateTest(TestDTO model)
        {
            var check = _test.Update(model);
            _test.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTest(int id)
        {
            var check = _test.Delete(id);

            _test.Save();
            return check;

        }
    }
}
