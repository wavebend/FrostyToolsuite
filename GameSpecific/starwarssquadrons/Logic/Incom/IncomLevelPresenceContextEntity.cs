using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomLevelPresenceContextEntityData))]
	public class IncomLevelPresenceContextEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomLevelPresenceContextEntityData>
	{
		public new FrostySdk.Ebx.IncomLevelPresenceContextEntityData Data => data as FrostySdk.Ebx.IncomLevelPresenceContextEntityData;
		public override string DisplayName => "IncomLevelPresenceContext";

		public IncomLevelPresenceContextEntity(FrostySdk.Ebx.IncomLevelPresenceContextEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

