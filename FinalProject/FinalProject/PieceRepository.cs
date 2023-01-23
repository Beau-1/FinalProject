using System.Data;
using System;
using System.Collections.Generic;
using Dapper;
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


    }
}
