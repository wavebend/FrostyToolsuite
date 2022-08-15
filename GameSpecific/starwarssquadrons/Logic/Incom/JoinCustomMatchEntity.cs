using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.JoinCustomMatchEntityData))]
	public class JoinCustomMatchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.JoinCustomMatchEntityData>
	{
		public new FrostySdk.Ebx.JoinCustomMatchEntityData Data => data as FrostySdk.Ebx.JoinCustomMatchEntityData;
		public override string DisplayName => "JoinCustomMatch";

		public JoinCustomMatchEntity(FrostySdk.Ebx.JoinCustomMatchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

