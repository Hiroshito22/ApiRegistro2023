using ApiRegistro2023.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiRegistro2023.Models;

namespace ApiRegistro2023.Controllers
{
    [Route("api/rol")]
    [ApiController]
    public class RolController : ControllerBase
    {
        //conectandonos con el contexto
        private readonly AppDbContext context;
        public RolController(AppDbContext context)
        { 
            this.context = context; 
        }
        //comenzamos a crear los metodos para el API
        //metodo para mostrar todos los roles
        //api/rol
        [HttpGet]
        public ActionResult findAll()
        {
            try { 
                return Ok(context.rol.ToList());
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            } 
        }
        //api/rol/5
        [HttpGet("{id}")]
        public ActionResult findById(int id)
        {
            try
            {
                var rol = context.rol.FirstOrDefault(r => r.codrol == id); return Ok(rol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //api/rol/cajero
        [HttpGet("name/{nom}")]
        public ActionResult findByName(string nom)
        {
            try
            {
                var rol = context.rol.FirstOrDefault(r => r.nomrol == nom);
                return Ok(rol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //api/rol/custom
        [HttpGet("custom")]
        public ActionResult findByCustom()
        {
            try
            {
                var rol = context.rol.Where(r => r.estrol == true);
                return Ok(rol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

    

