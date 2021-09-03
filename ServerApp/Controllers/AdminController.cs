using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using ServerApp.Repository;

namespace ServerApp.Controllers
{
   public  class AdminController : Controller
    {
        private readonly AdminRepository _adminRepository = new AdminRepository();

        [HttpPost("api/admin/add")]
        public IActionResult Add([FromBody] Admin admin)
        {


            var _addedAdmin = _adminRepository.Add(admin);
            return Ok(_addedAdmin);
        }

        [HttpGet("api/admin/get")]
        public IActionResult getProduct()
        {
            var admin = _adminRepository.GetAll();

            return Ok(admin);
        }

        [HttpGet("api/admin/getById")]
        public IActionResult getById(int adminId)
        {
            var admin = _adminRepository.GetById(adminId);

            return Ok(admin);
        }

        [HttpGet("api/admin/update")]
        public IActionResult update(Admin admin)
        {
            var obj = _adminRepository.Update(admin);

            return Ok(obj);
        }

        [HttpGet("api/admin/delete")]
        public IActionResult delete(Admin admin)
        {
            var obj = _adminRepository.Delete(admin);

            return Ok(obj);
        }
    }
}
