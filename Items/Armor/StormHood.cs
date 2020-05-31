using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StormMage.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    internal class StormHood : ModItem {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very nice hood.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 12;
            item.rare = ItemRarityID.Pink;
            item.vanity = true;
            //item.defense = 10;
        }


        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<StormRobe>();
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.SoulofFlight, 5);
            recipe.AddIngredient(ItemID.Wood);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }    
    }
}