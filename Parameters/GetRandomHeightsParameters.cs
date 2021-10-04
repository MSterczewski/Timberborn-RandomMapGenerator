using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMapGenerator.Parameters
{
	public class GetRandomHeightsParameters
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public int MinHeight { get; set; }
		public int MaxHeight { get; set; }
		public static GetRandomHeightsParameters Default() => new GetRandomHeightsParameters() { Height = 128, Width = 128, MaxHeight = 6, MinHeight = 2 };
	}
}
