using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;


namespace GameOfLife
{
	class Plant : BaseCell
	{

		public override Color GetColor()
		{
			return Color.FromArgb(124, 252, 0, 0);
		}

		public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
		{
			for (int i = -1; i < +2; i++)
			{
				for (int j = -1; j < +2; j++)
				{
					if (oldGrid[i + x, j + y] is Sand)
					{
						nextGrid[i + x, j + y] = new Plant();
					} 
					else if (oldGrid[i + x, j + y] is Water)
					{
						nextGrid[i + x, j + y] = new Plant();
					}
				}
			}

		}
	}
}
