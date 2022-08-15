using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroidVisualShootspaceEntityData))]
	public class DroidVisualShootspaceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DroidVisualShootspaceEntityData>
	{
		public new FrostySdk.Ebx.DroidVisualShootspaceEntityData Data => data as FrostySdk.Ebx.DroidVisualShootspaceEntityData;
		public override string DisplayName => "DroidVisualShootspace";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DroidVisualShootspaceEntity(FrostySdk.Ebx.DroidVisualShootspaceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

