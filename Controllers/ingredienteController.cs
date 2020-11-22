using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;

namespace xxx 
{
    [ApiController]
    [Route("[controller]")]
    public class ingredienteController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public ingredienteController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }

        [HttpGet]
        public List <Ingrediente> Get()
        {
            var ingredienteb = _db.Ingrediente
                .ToList();
            
            return ingredienteb;
        }
    }
}