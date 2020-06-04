using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StormMage.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    internal class StormRobe : ModItem {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very nice robes.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 14;
            item.rare = ItemRarityID.Pink;
            item.defense = 22;
        }

        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            equipSlot = StormMage.robesBottomSlot;
            robes = true;
        }


        public override void ArmorArmGlowMask(Player drawPlayer, float shadow, ref int glowMask, ref Color color) {
            glowMask = StormMage.robeArmGlowmask;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms) {
            drawHands = false;
        }


        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("StormHood");
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