using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
	public partial class Form1 : Form
	{
		LifeModel Model;

		public Form1()
		{
			InitializeComponent();
			Model = new LifeModel(60, 60);
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			Model.StepForward();
			base.OnMouseClick(e);
			Render();
		}

		public void Render()
		{
			var graphics = CreateGraphics();

			for (int i = 0; i < Model.MaxX; i++)
			{
				for (int j = 0; j < Model.MaxY; j++)
				{
					var value = Model.Grid[i, j].GetColor();
					graphics.FillRectangle(new SolidBrush(value), i*5, j * 5, 5, 5);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				while (true)
				{
					Model.StepForward();
					Render();
				}
			});
		}
	}
}
