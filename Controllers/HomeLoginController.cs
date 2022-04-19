using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System;

namespace WebApi.Controllers
{
    [ApiController]
    public class HomeLoginController : ControllerBase
    {
        private List<HomeLogin> _homelogin = new List<HomeLogin>
        {
            new HomeLogin {id=1, username = "Asif", password = "asif" },

        };
        private readonly StudentsContext _context;
       // private StudentsContext _student;
        public HomeLoginController(StudentsContext context)
        {
            _context = context;
            if (_context.HomeLogin.Count() == 0)
            {
                _context.HomeLogin.Add(new HomeLogin {id=1, username = "Asif", password = "asif" });  _context.SaveChanges();
            }
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAll()
        {
            return Ok(_homelogin);
        }

        [HttpPut]
        [Route("api/[controller]/detail")]
        public IActionResult GetById(HomeLogin homelogin)
        {
            var log = _context.HomeLogin.Where(b => b.username == homelogin.username).Where(b => b.password == homelogin.password);
            if (log == null)

                return NotFound();

            return Ok(log);
        }

         [HttpPost]
        [Route("api/[controller]/Create")]
        public IActionResult AddLogin(HomeLogin homelogin)
        {  
            var product1 = _context.HomeLogin.Count(a=>a.username==homelogin.username);
            try  
            {
             if (_context.HomeLogin.Count(a=>a.username==homelogin.username)==0 ){
                 _context.HomeLogin.Add(homelogin);  
                 _context.SaveChanges();  

             return Ok(product1);
                  }  

            } catch  
            {  
                throw;  
            }
            return Ok(product1);
        }


    }



}
