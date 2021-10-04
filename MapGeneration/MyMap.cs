using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timberborn.Persistence;

namespace RandomMapGenerator.MapGeneration
{
	public class MyMap
	{
		public string GameVersion = "v20210918-14def9e-sw";
		public string TimeStamp = "2021-10-03 11:05:46";
		//public string Singletons;
		public IEnumerable<EntitySave> Entities;
		public string GetSingletons()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(MapSizeString());
			stringBuilder.Append(",");
			stringBuilder.Append(TerrainMapString());
			stringBuilder.Append(",");
			stringBuilder.Append(CameraStateRestorer());
			return stringBuilder.ToString();
		}

		public int width = Defaults.Width;
		public int height = Defaults.Height;
		public int[,] heights;
		public string MapSizeString() => "\"MapSize\":{\"Size\":{\"X\":" + width + ",\"Y\":" + height + "}}";
		public string TerrainMapString() => "\"TerrainMap\":{\"Heights\":{\"Array\":\"" + Heights() + "\"}}";
		public string CameraStateRestorer() => "\"CameraStateRestorer\":{\"SavedCameraState\":{\"Target\":{\"X\":0.0,\"Y\":0.0,\"Z\":0.0},\"ZoomLevel\":0.0,\"HorizontalAngle\":30.0,\"VerticalAngle\":70.0}}";

		public string Heights()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (var v in heights)
			{
				stringBuilder.Append(v + " ");
			}
			return stringBuilder.ToString();
		}
		public string GetEntities()
		{
			return "[]";
		}
		public string ToJson()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"GameVersion\":\"v20210918 - 14def9e - sw\",\"TimeStamp\":\"2021-10-03 11:05:46\",\"Singletons\":{");
			stringBuilder.Append(GetSingletons());
			stringBuilder.Append("},");
			stringBuilder.Append("\"Entities\":");
			stringBuilder.Append(GetEntities());
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}
	}
}
