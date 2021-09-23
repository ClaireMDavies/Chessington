using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPosition;
            //find current location
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();


            // move up and right (-+)
            for (var i = 0; i < 8; i++)
            {
                newPosition = Square.At(currentPosition.Row -i, currentPosition.Col + i );
                if (!newPosition.Equals(currentPosition)&& newPosition.Row >= 0 && newPosition.Row <=7 && newPosition.Col >=0 && newPosition.Col <=7)
                {
                    availableSquares.Add(newPosition);
                }
            }
            //move down and right (++)
            for (var i = 0; i < 8; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col + i);
                if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            //move down and left (+-)
            for (var i = 0; i < 8; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col - i);
                if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }
            //move up and left (--)
            for (var i = 8; i > 0; i--)
            {
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col - i);
                if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            return availableSquares;
        }

    }
}