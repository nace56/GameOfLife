using System;
using System.Linq;
using System.Drawing;

namespace GameOfLife
{
	class OnCell : BaseCell
	{
		public override BaseCell StepForward(int x, int y, BaseCell[,] grid)
		{
			var count = GetNeighbors(x, y, grid).Count(c => c is OnCell);
			if (count < 2 || count >= 4)
			{
				return new OffCell();
			}

			return this;
		}

		public override Color GetColor()
		{
			return Color.FromArgb(255, 255, 255, 255);
		}
	}
}
