using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPosition;
            //find current location
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            // move up 2 and right 1 (- 2 +1)
            newPosition = Square.At(currentPosition.Row - 2, currentPosition.Col + 1);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
               availableSquares.Add(newPosition);
            }
            // move up 1 and right 2 (- 1 +2)
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col + 2);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }
            // move up 2 and left 1 (- 2 -1)
            newPosition = Square.At(currentPosition.Row - 2, currentPosition.Col - 1);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }
            // move up 1 and left 2 (- 1 -2)
            newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col - 2);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }
            // move down 2 and right 1 (+ 2 +1)
            newPosition = Square.At(currentPosition.Row + 2, currentPosition.Col + 1);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }
            // move down 1 and right 2 (+1 +2)
            newPosition = Square.At(currentPosition.Row +1, currentPosition.Col + 2);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }
            // move down 2 and left 1 (+ 2 -1)
            newPosition = Square.At(currentPosition.Row + 2, currentPosition.Col - 1);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }
            // move down 1 and left 2 (+ 1 -2)
            newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col - 2);
            if (!newPosition.Equals(currentPosition) && newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
            {
                availableSquares.Add(newPosition);
            }

            return availableSquares;
        }
        
    }
}