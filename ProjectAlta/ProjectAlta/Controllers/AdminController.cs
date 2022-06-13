using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;
using ProjectAlta.Data;
using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IEAdminRespository _AdRespo;
        public AdminController(Context context)
        {
            _AdRespo = new AdminRespository(context);
        }
        [HttpGet]
        public async Task<ActionResult<List<Admin>>> getAdmin()
        {
            var model = _AdRespo.GetAll();
            if (model == null)
            {
                return new List<Admin>();
            }
            return model.ToList();
        }
        [HttpPost]
        public async void AddAdmin(Admin model)
        {
            if (ModelState.IsValid)
            {
                _AdRespo.Insert(model);
                _AdRespo.Save();

            }

        }
    }
}
