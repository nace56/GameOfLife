using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife
{
	abstract class BaseCell
	{
		public abstract BaseCell StepForward(int x, int y, BaseCell[,] grid);

		public abstract Color GetColor();

		public IEnumerable<BaseCell> GetNeighbors(int x, int y, BaseCell[,] grid)
		{
			for (int i = - 1; i < + 2; i++)
			{
				for (int j = - 1; j < + 2; j++)
				{
					if (i != 0 || j != 0)
					{
						yield return grid[i, j];
					}
				}
			}
		}
	}
}
