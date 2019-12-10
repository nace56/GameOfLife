using System;
using System.Drawing;
using System.Linq;

namespace GameOfLife
{
	class OffCell : BaseCell
	{
		public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
		{
			var count = GetNeighbors(x, y, oldGrid).Count(c => c is OnCell);
			if (count == 3)
			{
				nextGrid[x,y] = new OnCell();
			}
		}

		public override Color GetColor()
		{
			return Color.FromArgb(255, 0, 0, 0);
		}
	}
}
