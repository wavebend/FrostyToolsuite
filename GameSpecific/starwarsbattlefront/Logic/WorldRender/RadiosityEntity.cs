using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadiosityEntityData))]
	public class RadiosityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RadiosityEntityData>
	{
		public new FrostySdk.Ebx.RadiosityEntityData Data => data as FrostySdk.Ebx.RadiosityEntityData;
		public override string DisplayName => "Radiosity";

		public RadiosityEntity(FrostySdk.Ebx.RadiosityEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

