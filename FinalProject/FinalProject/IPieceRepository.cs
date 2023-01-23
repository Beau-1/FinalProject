using System;
using System.Collections.Generic;
using FinalProject.Models;
namespace FinalProject
{
    public interface IPieceRepository
    {
        public IEnumerable<Piece> GetAllPieces();
    }
}
