using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSLogicPrefabReferenceObjectData))]
	public class WSLogicPrefabReferenceObject : LogicPrefabReferenceObject, IEntityData<FrostySdk.Ebx.WSLogicPrefabReferenceObjectData>
	{
		public new FrostySdk.Ebx.WSLogicPrefabReferenceObjectData Data => data as FrostySdk.Ebx.WSLogicPrefabReferenceObjectData;

		public WSLogicPrefabReferenceObject(FrostySdk.Ebx.WSLogicPrefabReferenceObjectData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

