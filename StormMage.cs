using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StormMage
{
	public class StormMage : Mod
	{
		

		public static int robesBottomSlot;

		public override void Load()
		{
			
			robesBottomSlot = this.AddEquipTexture(null, EquipType.Legs, "StromRobe_Legs", "StormMage/Items/Armor/StormRobe_Legs");
			
		}


	}
}