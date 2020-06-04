using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StormMage
{
	public class StormMage : Mod
	{
		public static int robeArmGlowmask;
		public static int robesBottomSlot;

		public override void Load()
		{
			this.Add
			robeArmGlowmask = this.AddEquipTexture(null, EquipType.Body, "StormRobe_Arms_Glowmask", "Stormmage/Items/Armor/StormRobe_Arms_Glowmask");
			robesBottomSlot = this.AddEquipTexture(null, EquipType.Legs, "StromRobe_Legs", "StormMage/Items/Armor/StormRobe_Legs");
			
			
		}


	}
}