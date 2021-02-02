using Game.Modding.Attributes;
using Game.Modding.Interfaces;
using HarmonyLib;
using UnityEngine;

namespace ExampleMod
{
    [Mod("ExampleMod", "1.0")]
    public class Main : IMod
    {
        public void Initialize()
        {
            Debug.Log("ExampleMod is being initialized...");

            var harmony = new Harmony("com.greyblockgames.olson.ExampleMod");
            harmony.PatchAll();
        }
    }
}