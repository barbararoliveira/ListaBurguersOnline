using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;

namespace xxx 
{
    [ApiController]
    [Route("[controller]")]
    public class burguerController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public burguerController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }

        [HttpGet]
        public List <Burguer> Get()
        {
            var burguer = _db.Burguer
                .ToList();
            
            return burguer;
        }
    }
}