using System;
using System.Collections.Generic;
using FinalProject.Models;

namespace FinalProject
{
    public interface IPieceRepository
    {
        public IEnumerable<Piece> GetAllPieces();

        public void UpdatePiece(Piece piece);


        public void InsertPiece(Piece pieceToInsert);

        public void DeletePiece(Piece piece);

        public Piece GetPiece(int pieceId);

    }
}
