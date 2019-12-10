using System;
using System.Drawing;
using System.Linq;

namespace GameOfLife
{
	class OffCell : BaseCell
	{
		public override BaseCell StepForward(int x, int y, BaseCell[,] grid)
		{
			var count = GetNeighbors(x, y, grid).Count(c => c is OnCell);
			if (count == 2 || count == 3)
			{
				return new OnCell();
			}

			return this;
		}

		public override Color GetColor()
		{
			return Color.FromArgb(255, 0, 0, 0);
		}
	}
}
