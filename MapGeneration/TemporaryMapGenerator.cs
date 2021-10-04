using Newtonsoft.Json;
using RandomMapGenerator;
using RandomMapGenerator.MapGeneration.MapGenerationModule;
using RandomMapGenerator.Parameters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timberborn.Persistence;
using UnityEngine;
using Random = System.Random;
namespace RandomMapGenerator.MapGeneration
{
	public class TemporaryMapGenerator
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public IMapGenerationModule mapGenerator { get; set; }
		public TemporaryMapGenerator(Vector2Int size)
		{
			Height = size.y;
			Width = size.x;
			mapGenerator = new SimplestMapGenerationModule();
		}
		public void Init()
		{
			MyMap map = new MyMap();
			map.height = Height;
			map.width = Width;
			map.Entities = new List<EntitySave>();
			map.heights = GetHeights();

			string output = map.ToJson();

			File.WriteAllText(Statics.FilePath, output);
		}
		public int[,] GetHeights()
		{
			var parameters = GetRandomHeightsParameters.Default();
			parameters.Height = Height;
			parameters.Width = Width;

			var res = mapGenerator.GetRandomHeights(parameters);
			return res.Heights;
		}
	}
}
