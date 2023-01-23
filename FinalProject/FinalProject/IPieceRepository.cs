using System;
using System.Collections.Generic;
using FinalProject.Models;
using Testing.Models;

namespace FinalProject
{
    public interface IPieceRepository
    {
        public IEnumerable<Piece> GetAllPieces();
    }
    public void UpdatePiece(Piece piece)
    {
        _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE PieceID = @id",
         new { name = piece.Name, price = piece.Price, id = piece.PieceID });
    }

    public void InsertPiece(Piece productToInsert);
    public IEnumerable<Category> GetCategories();
    public Piece AssignCategory();

    public void DeletePiece(Piece piece);
}
