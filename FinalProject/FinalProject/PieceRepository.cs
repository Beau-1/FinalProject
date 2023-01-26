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
            _conn.Execute("INSERT INTO pieces (NAME, PRICE, ARTIST, DESCRIPTION, IMAGE) VALUES (@name, @price, @artist, @description, @image);",
                new { name = pieceToInsert.Name, price = pieceToInsert.Price, pieceToInsert.Artist, description = pieceToInsert.Description, image = pieceToInsert.Image });
        }

        public void UpdatePiece(Piece piece)
        {
            _conn.Execute("UPDATE pieces SET Name = @name, Price = @price, Artist = @artist, Description = @description, Image = @image WHERE PieceID = @id",
             new { name = piece.Name, price = piece.Price, piece.Artist, piece.Description, piece.Image, id = piece.PieceID });
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
