using Game.Character.Abilities;
using Game.Character.Core;
using HarmonyLib;
using UnityEngine;

namespace ExampleMod
{
    [HarmonyPatch(typeof(GravityAbility))]
    [HarmonyPatch("FixedProcessAbility")]
    public class GravityAbilityPatch
    {
        static bool Prefix(GravityAbility __instance, ref float ___gravityMultiplier, ref CharacterHandler ___Handler)
        {
            ___Handler.AddMovement(Physics.gravity * (-___gravityMultiplier * Time.fixedDeltaTime));
            return false;
        }
    }
}