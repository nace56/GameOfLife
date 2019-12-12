using System;
using System.Linq;
using System.Drawing;

namespace GameOfLife
{
    class Fire : BaseCell
    {
        public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
        {
            for(int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    if(oldGrid[i + x, j + y] is Plant || oldGrid[i + x, j + y] is SlowPlague)
                    {
                        nextGrid[i + x, j + y] = new Fire();
                    }

                    if (oldGrid[i + x, j + y] is Ice)
                    {
                        nextGrid[i + x, j + y] = new Water();
                    }

                }
            }

        }

        public override Color GetColor()
        {
            return Color.FromArgb(255, 255, 255, 255);
        }
    }
}