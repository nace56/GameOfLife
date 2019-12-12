using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife
{
	public class Water : BaseCell
	{
		public override Color GetColor()
		{
			throw new NotImplementedException();
		}

		public override void StepForward(int x, int y, BaseCell[,] grid, BaseCell[,] nextGrid)
		{
			throw new NotImplementedException();
		}
	} // delete me
	public class Fire : BaseCell
	{
		public override Color GetColor()
		{
			throw new NotImplementedException();
		}

		public override void StepForward(int x, int y, BaseCell[,] grid, BaseCell[,] nextGrid)
		{
			throw new NotImplementedException();
		}
	}

	public class Ice : BaseCell
	{
		public override Color GetColor()
		{
			throw new NotImplementedException();
		}

		public override void StepForward(int x, int y, BaseCell[,] grid, BaseCell[,] nextGrid)
		{
			throw new NotImplementedException();
		}
	}

	public abstract class BaseCell
	{
		public abstract void StepForward(int x, int y, BaseCell[,] grid, BaseCell[,] nextGrid);

		public abstract Color GetColor();

		public IEnumerable<BaseCell> GetNeighbors(int x, int y, BaseCell[,] grid)
		{
			for (int i = - 1; i < + 2; i++)
			{
				for (int j = - 1; j < + 2; j++)
				{
					if (i != 0 || j != 0)
					{
						yield return grid[i + x, j + y];
					}
				}
			}
		}
	}
}
