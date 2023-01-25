using FinalProject.Models;

namespace FinalProject.Models
{
    public class Piece
    {
        public Piece() 
        
        {
        }

        public int PieceID{ get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
     
    }
}
