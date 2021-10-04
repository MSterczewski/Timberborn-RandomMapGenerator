using RandomMapGenerator.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMapGenerator.MapGeneration.MapGenerationModule
{
	public class SimplestMapGenerationModule : IMapGenerationModule
	{
		public GetRandomHeightsResult GetRandomHeights(GetRandomHeightsParameters parameters)
		{
			Random r = new Random();
			int[,] res = new int[parameters.Width, parameters.Height];
			for (int row = 0; row < parameters.Height; row++)
				for (int col = 0; col < parameters.Width; col++)
					res[col, row] = r.Next(parameters.MinHeight, parameters.MaxHeight);

			return new GetRandomHeightsResult() { Heights = res };
		}
	}
}
