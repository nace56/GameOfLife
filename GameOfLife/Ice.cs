using System;
using System.Linq;
using System.Drawing;

namespace GameOfLife
{
	class Ice : BaseCell
	{
		public override void StepForward(int x, int y, BaseCell[,] oldGrid, BaseCell[,] nextGrid)
		{
			var neighborCells = GetNeighbors(x, y, oldGrid, (i, j, c) => new Ice());
		}

		public override Color GetColor()
		{
			return Color.FromArgb(255, 0, 255, 255);
		}
	}

}
