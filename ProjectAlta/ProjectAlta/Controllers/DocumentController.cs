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
    public class DocumentController : ControllerBase
    {
        private IEDocumentRespository _DocRespo;
        private IMapper docmap;
        public DocumentController(IEDocumentRespository docrespo, IMapper mapper)
        {
            docmap = mapper;
            _DocRespo = docrespo;
        }
        [HttpGet]
        public async Task<ActionResult<List<DocumentDTO>>> getAllCourse()
        {
            var model = _DocRespo.GetAll();
            if (model == null)
            {
                return new List<DocumentDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddDoc(DocumentDTO model)
        {
            var check = _DocRespo.Insert(model);
            _DocRespo.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateDoc(DocumentDTO model)
        {
            var check = _DocRespo.Update(model);
            _DocRespo.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteDoc(int id)
        {
            var check = _DocRespo.Delete(id);

            _DocRespo.Save();
            return check;

        }
    }
}
