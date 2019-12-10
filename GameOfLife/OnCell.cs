using System;
using System.Linq;
using System.Drawing;

namespace GameOfLife
{
	class OnCell : BaseCell
	{
		public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
		{
			var count = GetNeighbors(x, y, oldGrid).Count(c => c is OnCell);
			if (count < 2 || count >= 4)
			{
				nextGrid[x,y] = new OffCell();
			}
		}

		public override Color GetColor()
		{
			return Color.FromArgb(255, 255, 255, 255);
		}
	}
}
