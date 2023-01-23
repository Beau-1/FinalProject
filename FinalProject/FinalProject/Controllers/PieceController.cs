using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class PieceController : Controller
    {

        private readonly IPieceRepository repo;

        public PieceController(IPieceRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetAllPieces();
            return View(products);
        }
    }
}