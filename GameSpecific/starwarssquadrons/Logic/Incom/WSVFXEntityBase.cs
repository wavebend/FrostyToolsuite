using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVFXEntityBaseData))]
	public class WSVFXEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.WSVFXEntityBaseData>
	{
		public new FrostySdk.Ebx.WSVFXEntityBaseData Data => data as FrostySdk.Ebx.WSVFXEntityBaseData;
		public override string DisplayName => "WSVFXEntityBase";

		public WSVFXEntityBase(FrostySdk.Ebx.WSVFXEntityBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

