using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace NoColonialRelations
{
	[HarmonyPatch(typeof(PawnGenerationRequest), "ColonistRelationChanceFactor", MethodType.Getter)]
	public static class ColonistRelationChanceFactor_Patch
    {
		public static bool Prefix(ref float __result)
		{
            __result = 0f;
			return false;
		}
	}
}
