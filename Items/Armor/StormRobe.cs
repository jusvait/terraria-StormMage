using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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

        public override void PostDrawInWorld(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch,
                                            Microsoft.Xna.Framework.Color lightColor,
                                            Microsoft.Xna.Framework.Color alphaColor,
                                            float rotation, float scale, int whoAmI) {

            Texture2D glowmask = mod.GetTexture("Items/Armor/StormRobe_Glowmask");

        }

        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            equipSlot = StormMage.robesBottomSlot;
            robes = true;
        }


        public override void DrawHands(ref bool drawHands, ref bool drawArms) {
            drawHands = true;
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