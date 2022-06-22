using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    public class LearningOutcomeController : ControllerBase
    {
        private IELearningOutcome _outcome;
        private IMapper map;

        public LearningOutcomeController(IELearningOutcome outcome, IMapper mapper)
        {
            map = mapper;
            _outcome = outcome;
        }

        [HttpGet]
        public async Task<ActionResult<List<LearningOutcomeDTO>>> getsub()
        {
            var model = _outcome.GetAll();
            if (model == null)
            {
                return new List<LearningOutcomeDTO>();
            }
            return model.ToList();
        }

        [HttpPost]
        public ActionResult<bool> AddSub(LearningOutcomeDTO model)
        {
            var check = _outcome.Insert(model);
            _outcome.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateTest(LearningOutcomeDTO model)
        {
            var check = _outcome.Update(model);
            _outcome.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTest(int id)
        {
            var check = _outcome.Delete(id);

            _outcome.Save();
            return check;

        }
    }
}
