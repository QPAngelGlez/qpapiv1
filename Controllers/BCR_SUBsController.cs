using System.Collections.Generic;
using CoreAPIQPro.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CoreAPIQPro.Controllers
{
    [ApiController]
    [Route("Subsidiarias")]
    public class BCR_SUBsController : ControllerBase
	{
        readonly GetDataClass instanciaAuxiliar = new();

        [HttpGet]
        [Route("GetContacts")]
        public IActionResult GetContacts_Test()
        {
            var contacts = instanciaAuxiliar.GetContactsFile("SUB_Test_v1.json");
            return Ok(contacts);
        }
    }
}

