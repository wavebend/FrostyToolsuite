using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DirectionalLocatorEntityData))]
	public class DirectionalLocatorEntity : LocalLocatorEntity, IEntityData<FrostySdk.Ebx.DirectionalLocatorEntityData>
	{
		public new FrostySdk.Ebx.DirectionalLocatorEntityData Data => data as FrostySdk.Ebx.DirectionalLocatorEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DirectionalLocatorEntity(FrostySdk.Ebx.DirectionalLocatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

