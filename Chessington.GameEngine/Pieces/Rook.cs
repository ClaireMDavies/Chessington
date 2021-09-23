using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }
        
        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPosition;
            //find current location
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            //moving rook  horizontally 
            for (var i = 0; i < 8; i++)
            {
                newPosition = Square.At(currentPosition.Row, i);
                if (!newPosition.Equals(currentPosition))
                {
                    availableSquares.Add(newPosition);
                }
               
            }
            
            //moving rook vertically
            for (var i = 0; i < 8; i++)
            {
                newPosition = Square.At(i , currentPosition.Col);
                if (!newPosition.Equals(currentPosition))
                {
                    availableSquares.Add(newPosition);
                }

            }

            return availableSquares;

           

        }
    }
}