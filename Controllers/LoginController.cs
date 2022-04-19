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
    //[Route("api/[controller]")]
    public class LoginController : ControllerBase
    {


        private List<Login> _login = new List<Login>
        {
            new Login {id=1, username = "Arun" , mail = "arun@gmail.com" , password = "SynapseArun" },
            // new Login { mail = "jadav@gmail.com" , password = "SynapseJadav" },
            // new Login { mail = "ritu@gmail.com" , password = "SynapseRitu" },
            // new Login { mail = "kumar@gmail.com" , password = "Synapsekumar" },
            // new Login { mail = "barat@gmail.com" , password = "SynapseBarat" },            

        };
         private readonly StudentsContext _context;
       // private StudentsContext _student;
        public LoginController(StudentsContext context)
        {
            _context = context;
            if (_context.Login.Count() == 0)
            {
                _context.Login.Add(new Login {id=1, username = "Arun" , mail = "arun@gmail.com" , password = "SynapseArun" });  _context.SaveChanges();
            }
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAll()
        {
            return Ok(_login);
        }

        [HttpPut]
        [Route("api/[controller]/detail")]
        public IActionResult GetById(Login login)
        {            
                var log =   _context.Login.Where(b =>b.mail ==login.mail).Where(b =>b.password ==login.password);
                    if (log == null)

                return NotFound();

            return Ok(log);            
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public IActionResult AddLogin(Login login)
        {  
            var product1 = _context.Login.Count(a=>a.mail==login.mail);
            try  
            {
             if (_context.Login.Count(a=>a.mail==login.mail)==0 ){
                 _context.Login.Add(login);  
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