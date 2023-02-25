using System;
using HarmonyLib;
using Verse;

namespace NoColonialRelations
{
	public class NoColonialRelations : Mod
	{
		public NoColonialRelations(ModContentPack content) : base(content)
		{
			new Harmony("Bar0th.NoColonialRelations").PatchAll();
		}
	}
}
