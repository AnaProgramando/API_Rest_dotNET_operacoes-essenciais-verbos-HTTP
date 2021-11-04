using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    // Todos os derivados do tipo API controle são feitos para dar uma resposta API HTTP. Os controladores com este atributo são configurados com recursos e comportamento direcionados a melhorar a experiência do desenvolvedor para a construção de APIs.
    [ApiController]
    // O "controller" está fazendo referência automaticamente ao nome do controlador, ou seja, essa referência não precisará ser alterada, caso o nome do controlador mude
    [Route("controller")]

    // Estendi a ControllerBase para dar a FilmeController os comportamentos base do controlador
    public class FilmeController : ControllerBase
    {
        // A classe FilmeController é capaz de receber e enviar requisições por utilizar ApiController
        public void AdicionarFilme(FilmeController filme)
        {

        }
    }
}
