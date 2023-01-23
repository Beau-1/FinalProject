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
            var piece = repo.GetAllPieces();
            return View(piece);
        }

        public IActionResult UpdatePiece(int id)
        {
            Piece prod = repo.GetPiece(id);
            if (prod == null)
            {
                return View("PieceNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateProductToDatabase(Piece piece)
        {
            repo.UpdatePiece(piece);

            return RedirectToAction("ViewPiece", new { id = piece.PieceID });
        }

        public IActionResult InsertPiece()
        {
            var prod = repo.AssignCategory();
            return View(prod);
        }

        public IActionResult InsertProductToDatabase(Piece pieceToInsert)
        {
            repo.InsertPiece(pieceToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(Piece piece)
        {
            repo.DeletePiece(piece);
            return RedirectToAction("Index");
        }
    }
}