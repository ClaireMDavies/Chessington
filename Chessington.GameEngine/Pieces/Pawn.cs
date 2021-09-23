using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        
        public Pawn(Player player) 
            : base(player) {  }


        

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPosition;
            //find current location
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

           

            if (Player == Player.White)
            {
                if(firstMove == true)
                {
                    newPosition = Square.At(currentPosition.Row - 2, currentPosition.Col);
                    availableSquares.Add(newPosition);

                    newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col);
                    availableSquares.Add(newPosition);
                    firstMove = false;
                }
                else
                {
                    //find square one up from it
                    newPosition= Square.At(currentPosition.Row - 1, currentPosition.Col);
                    //put that square in list 
                    availableSquares.Add(newPosition);

                }
            }
            else
            {
                if (firstMove == true)
                {
                    newPosition = Square.At(currentPosition.Row + 2, currentPosition.Col);
                    availableSquares.Add(newPosition);

                    newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col);
                    availableSquares.Add(newPosition);


                    firstMove = false;
                }
                else
                {
                    //find square one down from it
                    newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col);

                    //put that square in list 
                    availableSquares.Add(newPosition);

                }
                

            }

            
            return availableSquares;

        }
    }
}