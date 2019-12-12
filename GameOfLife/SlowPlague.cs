using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife
{
	class SlowPlague : BaseCell
	{
		private int Shade = 100;

		public override Color GetColor()
		{
			return Color.FromArgb(255, Shade, Shade, Shade);
		}

		public override void StepForward(int x, int y, BaseCell[,] grid, BaseCell[,] nextGrid)
		{
			Random r = new Random();
			if (r.NextDouble() < .01)
			{
				for (int i = -1; i < +2; i++)
				{
					for (int j = -1; j < +2; j++)
					{
						nextGrid[i + x, j + y] = new SlowPlague() { Shade = Shade + 10 };
					}
				}
			}
		}
	}
}
