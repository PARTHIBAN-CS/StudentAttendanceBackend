//  using System;
// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using WebApi.Entities;
// using System.Linq;
// using System.Data;
// using System.Text;
// using RestSharp;
// using Newtonsoft.Json;
// namespace Demo
// {
//     public class Demo
//     {
//         public Student GetAllvalue()
//         {
//             var restClient = new RestClient("https://localhost:5001/");
//             var restRequest = new RestRequest("api/students/",Method.Get);
//             restRequest.AddHeader("Accept","application/json");
//             restRequest.RequestFormat = DataFormat.Json;

//             IRestResponse response = restClient.Execute(restRequest);
//             var content = response.Content;

//             var users = JsonConvert.DeserializeObject<Student>(content);
//             return users; 

//         }
//     }
// }