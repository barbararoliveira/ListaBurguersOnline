using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;
using listaburguersonline.Models;

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
        public List <listaburguersonlineModels> Get()
        {
           var hamburguerfinish = _db.Burguer;
            
            var retorno = new List<listaburguersonlineModels>();
            foreach(var hb in hamburguerfinish)
            {
                retorno.Add(new listaburguersonlineModels{
                    Nome = hb.Nome
                });
            }    
            return retorno;
        }
    }
}