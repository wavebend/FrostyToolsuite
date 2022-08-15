using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipLauncherEntityData))]
	public class StarshipLauncherEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipLauncherEntityData>
	{
		public new FrostySdk.Ebx.StarshipLauncherEntityData Data => data as FrostySdk.Ebx.StarshipLauncherEntityData;
		public override string DisplayName => "StarshipLauncher";

		public StarshipLauncherEntity(FrostySdk.Ebx.StarshipLauncherEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

