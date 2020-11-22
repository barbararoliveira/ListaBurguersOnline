using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;

namespace xxx 
{
    [ApiController]
    [Route("[controller]")]
    public class tipoController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public tipoController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }

        [HttpGet]
        public List <TipoIngrediente> Get()
        {
            var tipo = _db.TipoIngrediente
                .ToList();
            
            return tipo;
        }
    }
}