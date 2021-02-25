using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElectricityMod.Items
{
    class ScrewDriver : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Screw Driver");
            Tooltip.SetDefault("Use this item to place cables");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
        }

    }
}
