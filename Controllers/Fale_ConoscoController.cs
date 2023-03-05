using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using black_shoes.Models;

namespace black_shoes.Controllers
{
    public class Fale_ConoscoController : Controller
    {
        public IActionResult Atendimento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atendimento(Fale_Conosco fale_Conosco)
        {
            Fale_ConoscoBD.Inserir(fale_Conosco);
            return View("Confirmacao");
        }

        public  IActionResult Lista()
        {
            List<Fale_Conosco> fale_Conosco= Fale_ConoscoBD.Listar();
            return View(fale_Conosco);            
        } 

         public IActionResult Editar(int id) 
        {
          Fale_Conosco fale_Conosco = Fale_ConoscoBD.BuscarPorId(id);
            return View(fale_Conosco);
        }

        [HttpPost]
        public IActionResult Editar(Fale_Conosco fale_Conosco) {
            Fale_ConoscoBD.Atualizar(fale_Conosco);
            return RedirectToAction("Lista");
        }

        public IActionResult Remover(int id) {
            Fale_ConoscoBD.Remover(id);
            return RedirectToAction("Lista");
        }
    }
}