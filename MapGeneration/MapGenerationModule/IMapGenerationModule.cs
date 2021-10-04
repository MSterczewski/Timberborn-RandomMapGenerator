using RandomMapGenerator.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMapGenerator.MapGeneration.MapGenerationModule
{
	public interface IMapGenerationModule
	{
		public GetRandomHeightsResult GetRandomHeights(GetRandomHeightsParameters parameters);
	}
}
