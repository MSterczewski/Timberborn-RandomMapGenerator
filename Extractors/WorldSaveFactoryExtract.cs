using HarmonyLib;
using System;
using Timberborn.EntitySystem;
using Timberborn.Persistence;
using Timberborn.SingletonSystem;
using UnityEngine;

namespace RandomMapGenerator.Extractors
{
	//[HarmonyPatch(typeof(WorldSaveFactory))]
	//[HarmonyPatch("Create", new Type[] { })]
	//class WorldSaveFactoryExtract
	//{
	//	public static bool Prefix(WorldSaveFactory __instance, EntityService ____entityService, ISingletonRepository ____singletonRepository, PrefabNameRetriever ____prefabNameRetriever, ObjectSerializationService ____objectSerializationService)
	//	{
	//		WorldSave worldSave = new WorldSave
	//		{
	//			GameVersion = Application.version
	//		};

	//		//SaveEntities()
	//		foreach (GameObject entity in ____entityService.Entities)
	//		{
	//			Statics.Logger.LogInfo("Entity:" + entity.name);
	//			string prefabName = ____prefabNameRetriever.GetPrefabName(entity);
	//			EntitySave entitySave = new EntitySave(entity.GetComponent<EntityComponent>().EntityId, prefabName);
	//			SaveEntity(entity, entitySave, ____objectSerializationService);
	//			if (entitySave.HasComponents())
	//			{
	//				worldSave.AddEntity(entitySave);
	//			}
	//		}

	//		//SaveSingletons
	//		SingletonSaver singletonSaver = new SingletonSaver(____objectSerializationService, worldSave);
	//		foreach (ISaveableSingleton singleton in ____singletonRepository.GetSingletons<ISaveableSingleton>())
	//		{
	//			Statics.Logger.LogInfo("Singleton:" + singleton.GetType().Name);
	//			singleton.Save(singletonSaver);
	//		}

	//		return true;


	//	}
	//	private static void SaveEntity(GameObject gameObject, EntitySave output, ObjectSerializationService _objectSerializationService)
	//	{
	//		Component[] components = gameObject.GetComponents<Component>();
	//		foreach (Component component in components)
	//		{
	//			if (component is ISaveableSingleton)
	//			{
	//				throw new ArgumentException("An entity must not implement ISaveableSingleton: " + component.GetType().Name);
	//			}
	//			(component as IPersistentEntity)?.Save(new EntitySaver(_objectSerializationService, output));
	//		}
	//	}

	//}
}
