using System;
using System.Drawing;
using System.Linq;

namespace GameOfLife
{
	class Water : BaseCell
	{
		public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
		{


            //falls
            if (!oldGrid[x, y - 1] is Sand &&
                !oldGrid[x, y - 1] is Ice &&
                !oldGrid[x, y - 1] is Water) //can't go through these cells
            {
                newGrid[x, y] = new OffCell(); //turn old cell (above) off?
                newGrid[x, y - 1] = new Water(); 
            }


            //kills fire
            for (int i = -1; i < +2; i++)
            {
                for (int j = -1; j < +2; j++)   //iterate over neighbors
                {
                    if(oldGrid[i,j] is Fire)    
                    {
                        nextGrid[i,j] = new OffCell(); //turn off all fire neighbors
                    }
                }

            }


		}

		public override Color GetColor()
		{
			return Color.FromArgb(255, 0, 0, 255); //blue
		}
	}
}
