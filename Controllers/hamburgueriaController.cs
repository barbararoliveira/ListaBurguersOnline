using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;

namespace xxx 
{
    [ApiController]
    [Route("[controller]")]
    public class hamburgueriaController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public hamburgueriaController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }

        [HttpGet]
        public List <BurguerIngrediente> Get()
        {
            var ingrediente = _db.BurguerIngrediente
                .ToList();
            
            return ingrediente;
        }
    }
}