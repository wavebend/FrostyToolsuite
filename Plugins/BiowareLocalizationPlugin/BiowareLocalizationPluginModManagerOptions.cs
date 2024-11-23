
using Frosty.Core;
using FrostySdk.Attributes;

namespace BiowareLocalizationPlugin
{
    [DisplayName("Bioware Localization Options")]
    public class BiowareLocalizationPluginOptions : OptionsExtension
    {

        // The name for the global mod manager variable.
        public static readonly string SHOW_INDIVIDUAL_TEXTIDS_OPTION_NAME = "BwLoMoShowIndividualTextIds";

        [Category("Mod Manager Options")]
        [Description("If enabled, all individual text ids in each resource (res) are shown in the mod manager's Actions tab. Otherwise only the resource iteself is shown as merged. This setting is only for the mod manager and has no effect in the editor.")]
        [DisplayName("Show Individual Text Ids")]
        [EbxFieldMeta(FrostySdk.IO.EbxFieldType.Boolean)]
        public bool ShowIndividualTextIds { get; set; } = false;

        public override void Load()
        {
            // mod manager
            ShowIndividualTextIds = Config.Get(SHOW_INDIVIDUAL_TEXTIDS_OPTION_NAME, false, ConfigScope.Global);
        }

        public override void Save()
        {
            // mod manager
            Config.Add(SHOW_INDIVIDUAL_TEXTIDS_OPTION_NAME, ShowIndividualTextIds, ConfigScope.Global);
        }
    }
}
