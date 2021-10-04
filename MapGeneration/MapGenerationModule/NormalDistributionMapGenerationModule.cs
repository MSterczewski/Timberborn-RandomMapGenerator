using RandomMapGenerator.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMapGenerator.MapGeneration.MapGenerationModule
{
	public class NormalDistributionMapGenerationModule : IMapGenerationModule
	{
		public GetRandomHeightsResult GetRandomHeights(GetRandomHeightsParameters parameters)
		{
			//Generated from https://planetcalc.com/4986/ with Mean 4, Variance 1, Point 100
			//List<(int maxHeight, int height)> normalDistribution = new List<(int, int)>()
			//{
			//	(44,1),
			//	(584,2),
			//	(3004,3),
			//	(6993,4),
			//	(9413,5),
			//	(9953,6),
			//};
			List<int> normalDistribution = new List<int>()
			{
				44,
				584,
				3004,
				6993,
				9413,
				9953
			};

			Random r = new Random();
			int[,] res = new int[parameters.Width, parameters.Height];
			for (int row = 0; row < parameters.Height; row++)
				for (int col = 0; col < parameters.Width; col++)
				{
					var generatedNumber = r.Next(10000);
					int val = 1;
					foreach(var distribution in normalDistribution)
					{
						if (generatedNumber > distribution)
							val++;
						else
							break;
					}
					res[col, row] = val;
				}


			return new GetRandomHeightsResult() { Heights = res };
		}
	}
}
