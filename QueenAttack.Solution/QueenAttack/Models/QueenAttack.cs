using System;
namespace QueenAttack
{
    public class Queen
    {
        private int _QueenX;
        private int _QueenY;
        private int _X;
        private int _Y;

        public Queen(int QueenX, int QueenY, int X, int Y)
        {
            _QueenX = QueenX;
            _QueenY = QueenY;
            _X = X;
            _Y = Y;
        }
        public bool CanAttack()
        {
            bool result = ((_QueenX == _X) && (_QueenY == _Y)) ? false :
                ((_QueenX == _X) || _QueenY == _Y || (Math.Abs(_QueenX - _X) == Math.Abs(_QueenY - _Y))) ? true :
                false;
            return result;
        }
    }
}