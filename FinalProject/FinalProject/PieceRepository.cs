using System.Data;
using System;
using System.Collections.Generic;
using Dapper;
using Testing.Models;

namespace FinalProject.Models
{
    public class PieceRepository : IPieceRepository
    {
        private readonly IDbConnection _conn;
        public PieceRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Piece> GetAllPieces()
        {
            return _conn.Query<Piece>("SELECT * FROM PIECES;");
        }

        public void InsertPiece(Piece pieceToInsert)
        {
            _conn.Execute("INSERT INTO pieces (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
                new { name = pieceToInsert.Name, price = pieceToInsert.Price, categoryID = pieceToInsert.CategoryID });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public Piece AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Piece();
            piece.Categories = categoryList;
            return piece;
        }

        public void DeletePiece(Piece piece)
        {
            _conn.Execute("DELETE FROM REVIEWS WHERE PieceID = @id;", new { id = piece.PieceID });
            _conn.Execute("DELETE FROM Sales WHERE PieceID = @id;", new { id = piece.PieceID });
            _conn.Execute("DELETE FROM Pieces WHERE PieceID = @id;", new { id = piece.PieceID });
        }
    }
}
