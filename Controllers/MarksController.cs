// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using WebApi.Entities;
//  using System.Linq;
//  using System.Threading.Tasks;
//  using System.Data;
//  using System.Diagnostics;

// namespace WebApi.Controllers
// {
//     [ApiController]
//     //[Route("api/[controller]")]
//     public class MarksController : ControllerBase
//     {
        
      
//         private List<Mark> _Marks= new List<Mark>
//         {
//             new Mark { id=1, rollno=1, mark1Value= 1,mark2Value=1,mark3Value=1,totalmarks=1 },
//            // new Student { rollno = 2, firstname = "mani" ,lastname ="k", gender ="Male" ,phoneno ="9876543210" },
//            //  new Student { rollno = 3, firstname = "murugan" ,lastname ="v", gender ="Male" ,phoneno ="8012261027" },
//            // new Student { rollno = 4, firstname = "sabari" ,lastname ="r", gender ="Male" ,phoneno ="9876543210" },
//         };
//          private readonly MarksContext _context;
//         public MarksController(MarksContext context)         
// {             _context = context;              
// if (_context.Marks.Count() == 0)             
// {                 
//    _context.Marks.Add(new Mark {id=1, rollno=1, mark1Value= 1,mark2Value=1,mark3Value=1,totalmarks=1});                _context.SaveChanges();             
// }         
// } 




//         // [HttpGet]
//         // public IActionResult GetAll()
//         // {
//         //     return Ok(_students);
//         // }

//         // [HttpGet("{rollno}")]
//         // public IActionResult GetById(int rollno)
//         // {
//         //     var student = _students.Find(x => x.rollno == rollno);
//         //     if (student == null)
//         //         return NotFound();

//         //     return Ok(student);
//         // }
// //  [HttpGet] 
// //     [Route("api/test")]
// //   public string GetAll() 
// // {     
// // return "Working";
// //}
//     [HttpGet] 
//     [Route("api/[controller]/id")]
//   public List<Mark> GetAll(int id) 
// {     
// return _context.Marks.OrderBy(id => id).ToList();
// }

// // [HttpGet] 
// //     [Route("api/[controller]/rollno")]
// //   public ActionResult<List<Student>> selectAll() 
// // {     
// // return _context.Students.ToList(); 
// // }
// //  [HttpGet]  
// //         [Route("api/[Controller]/rollno")] 
// // public ActionResult <List<Student>> GetAll()  
// //         // {  
// //         //     try  
// //             {  
// //                 return _context.Students.ToList();  
// //             }  
// //             catch  
// //             {  
// //                 throw;  
// //             }  
// //         }  
//  [HttpPost]  
//         [Route("api/[controller]/Create")]  
// //To Add new employee record  
//  public List<Mark> AddMark( Mark mark)  

//         {  

//             try  

//             {  

//                 _context.Marks.Add(mark);  

//                _context.SaveChanges();

//               var id = mark.id;

//                //Debug.WriteLine(rollno);

//                List<Mark> st=new List<Mark>();

//                st.Add(mark);

//              return st;

//             }  

//             catch  

//             {  

//                 throw;  

//             }  

//         }
//            [HttpPut]  
//         [Route("api/[controller]/Edit/{id}")]  
 
//         //To Update the records of a particluar employee    
//         public int UpdateMarks(int id, Mark mark)  

//         {
//             try
//             {
//             var result = _context.Marks.SingleOrDefault(b => b.id ==id );
//     if (result != null)
//     {
//         result.mark1Value = mark.mark1Value;
//          result.mark2Value = mark.mark2Value;
//           //result.rollno = mark.rollno;
//            result.mark3Value = mark.mark3Value;
//             result.totalmarks = mark.totalmarks;
//         _context.SaveChanges();
//         return 1;
//     }
//     return 1;
//             }
//     catch  
//             {  
//                 throw;  
//             }  
//             }
//          [HttpDelete]  
//         [Route("api/[controller]/Delete/{id}")] 
//          //To Delete the record of a particular employee    
//         public int DeleteMark(int id)  
//         {  
//             try  
//             {  
//                 Mark emp = _context.Marks.Find(id);  
//                _context.Marks.Remove(emp);  
//                 _context.SaveChanges();  
//                 return 1;  
//             }  
//             catch  
//             {  
//                 throw;  
//             }  
//         }  
          
// //Get the details of a particular employee    
//   //Get the details of a particular employee 
  
//         [HttpGet]  
//         [Route("api/[controller]/Details/{id}")]     
//         public Mark GetMarksData(int id)  
//         {  
//             try  
//             {  
//                 Mark employee = _context.Marks.Find(id);  
//                 return employee;  
//             }  
//             catch  
//             {  
//                 throw;  
//             }  
//         }
//     } 
// }
     
   