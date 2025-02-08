using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ReforgesReworked.Content.Config {

    public class PrefixConfig : ModConfig {

        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Header("VanillaReforges")]
        [DefaultValue(false)]
        [Tooltip("Note that turning this on will remove any vanilla reforges currently on your character!")]

        [ReloadRequired]
        public bool DisableVanillaPrefixToggle;
    }

    public class DebugConfig : ModConfig {

        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Header("Debug")]
        [DefaultValue(false)]
        [Tooltip("Debug things")]

        [ReloadRequired]
        public bool Debug;
    }
}