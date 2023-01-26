using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

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

        public IActionResult UpdatePieceToDatabase(Piece piece)
        {
            repo.UpdatePiece(piece);

            return RedirectToAction("ViewPiece", new { id = piece.PieceID });
        }

        public IActionResult InsertPiece()
        {
            var piece = new Piece();
            return View(piece);
        }

        public IActionResult InsertPieceToDatabase(Piece pieceToInsert)
        {
            repo.InsertPiece(pieceToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePiece(Piece piece)
        {
            repo.DeletePiece(piece);
            return RedirectToAction("Index");
        }

        public IActionResult ViewPiece(int id)
        {
            var piece = repo.GetPiece(id);
            return View(piece);
        }

        public IActionResult Gallery(int id)
        {
            var piece = repo.GetPiece(id);
            return View(piece);
        }
    }
}