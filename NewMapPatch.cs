using HarmonyLib;
using RandomMapGenerator.MapGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timberborn.EntitySystem;
using Timberborn.MapEditorSceneLoading;
using Timberborn.MapSystem;
using Timberborn.Persistence;
using Timberborn.SingletonSystem;
using UnityEngine;

namespace RandomMapGenerator
{
	[HarmonyPatch(typeof(MapEditorSceneLoader))]
	[HarmonyPatch("StartNewMap")]
	class NewMapPatch
	{
		//Overrides starting new map with generating some hardcoded map into "tmp.json" file and then loading it
		public static bool Prefix(Vector2Int mapSize, MapEditorSceneLoader __instance)
		{
			Statics.Logger.LogInfo("Creating new randomised map");
			TemporaryMapGenerator mapper = new TemporaryMapGenerator(mapSize);
			mapper.Init();


			Statics.Logger.LogInfo("Loading randomised map");
			MapFileReference mapFileReference = MapFileReference.FromDisk("tmp");
			__instance.LoadMap(mapFileReference);
			Statics.Logger.LogInfo("Finished loading");
			return false;
		}
	}
}
