using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VisualLightSaberEntityData))]
	public class VisualLightSaberEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VisualLightSaberEntityData>
	{
		public new FrostySdk.Ebx.VisualLightSaberEntityData Data => data as FrostySdk.Ebx.VisualLightSaberEntityData;
		public override string DisplayName => "VisualLightSaber";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VisualLightSaberEntity(FrostySdk.Ebx.VisualLightSaberEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

