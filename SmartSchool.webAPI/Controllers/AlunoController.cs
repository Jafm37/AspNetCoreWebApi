using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.webAPI.Models;

namespace SmartSchool.webAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController: ControllerBase
    {
        public List<Aluno>Alunos = new List<Aluno>(){
            new Aluno(){
                Id=1,
                Nome="Laura",
                Sobrenome="Almeida",
                Telefone="27921927"
            },
            new Aluno(){
                Id=2,
                Nome="Rafael",
                Sobrenome="Rodrigues",
                Telefone="27921943"
            },
            new Aluno(){
                Id=3,
                Nome="Marta",
                Sobrenome="Kent",
                Telefone="27921960"
            },
        };
        public AlunoController() {  }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
            
        }
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(Alunos);
            
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(Alunos);
            
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(Alunos);
            
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(Alunos);
            
        }
        
    }
}