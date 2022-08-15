using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FirstPartyGamercardEntityData))]
	public class FirstPartyGamercardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FirstPartyGamercardEntityData>
	{
		public new FrostySdk.Ebx.FirstPartyGamercardEntityData Data => data as FrostySdk.Ebx.FirstPartyGamercardEntityData;
		public override string DisplayName => "FirstPartyGamercard";

		public FirstPartyGamercardEntity(FrostySdk.Ebx.FirstPartyGamercardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

