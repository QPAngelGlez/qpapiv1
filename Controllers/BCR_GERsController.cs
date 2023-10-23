using System.Collections.Generic;
using CoreAPIQPro.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CoreAPIQPro.Controllers
{
    [ApiController]
    [Route("Gerencias")]
    public class BCR_GERsController : ControllerBase
    {
        readonly GetDataClass instanciaAuxiliar = new();

        [HttpGet]
        [Route("GetContacts")]
        public IActionResult GetContacts_Test()
        {
            var contacts = instanciaAuxiliar.GetContactsFile("GER_Test_v1.json");
            return Ok(contacts);
        }
    }
}




//==============================================================================
//using System;
//using System.IO;
//using System.Text.Json;
//using CoreAPIQPro.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace CoreAPIQPro.Controllers
//{
//    [ApiController]
//    [Route("Gerencias")]
//    public class BCR_GERsController : ControllerBase
//    {
//        [HttpGet]
//        [Route("GetContacts")]
//        public dynamic GetContacts()
//        {
//            string json = @"{
//                { email ='angel.gonzalez@questionpro.com', url='https://www.google.com' },
//                { email ='alejandro.caballero@questionpro.com', url='https://www.google.com' },
//                { email ='roberto.pacheco@questionpro.com', url='https://www.google.com' }
//            }";
//            ListContact contacts = new ListContact();
//            contacts = JsonSerializer.Deserialize<ListContact>(json);
//            return contacts;
//        }
//	}
//}