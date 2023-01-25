using System.Data;
using System;
using System.Collections.Generic;
using Dapper;
using FinalProject.Models;

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
            _conn.Execute("INSERT INTO pieces (NAME, PRICE) VALUES (@name, @price);",
                new { name = pieceToInsert.Name, price = pieceToInsert.Price });
        }

        public void UpdatePiece(Piece piece)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE PieceID = @id",
             new { name = piece.Name, price = piece.Price, id = piece.PieceID });
        }

        public void DeletePiece(Piece piece)
        {
            
            _conn.Execute("DELETE FROM Pieces WHERE PieceID = @id;", new { id = piece.PieceID });
        }

        public Piece GetPiece(int id)
        {
            return _conn.QuerySingle<Piece>("SELECT * FROM PIECES WHERE PieceId = @id;",new {id = id});
        } 
    }
}
