using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace GameOfLife
{
    class Sand : BaseCell
    {
        public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
        {
            if (y - 1 >= 0)
            {
                var cellBelow = oldGrid[x, y - 1];
                if (cellBelow is Fire || cellBelow is OffCell)
                {
                    nextGrid[x, y] = new OffCell();
                    nextGrid[x, y - 1] = new Sand();
                }
                else if (cellBelow is Water)
                {
                    nextGrid[x, y] = new Water();
                    nextGrid[x, y - 1] = new Sand();
                }
            }
        }

        public override Color GetColor()
        {
            return Color.FromArgb(255, 200, 150, 0);
        }
    }
}
