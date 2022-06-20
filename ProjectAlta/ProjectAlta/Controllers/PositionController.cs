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
    public class PositionController : ControllerBase
    {
        private IEPositionRespository _PosRespo;
        private IMapper admap;
        public PositionController(IEPositionRespository posrespo, IMapper mapper)
        {
            admap = mapper;
            _PosRespo = posrespo;
        }


        [HttpGet]
        public async Task<ActionResult<List<PositionDTO>>> getPos()
        {
            var model = _PosRespo.GetAll();
            if (model == null)
            {
                return new List<PositionDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddPos(PositionDTO model)
        {
            var check = _PosRespo.Insert(model);
            _PosRespo.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdatePos(PositionDTO model)
        {
            var check = _PosRespo.Update(model);
            _PosRespo.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteGra(int id)
        {
            var check = _PosRespo.Delete(id);

            _PosRespo.Save();
            return check;

        }
    }
}
