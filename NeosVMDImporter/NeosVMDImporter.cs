using BaseX;
using FrooxEngine;
using HarmonyLib;
using NeosModLoader;
using System.Collections.Generic;
using System;
using CodeX;
using Scallion;

namespace NeosVMDImporter
{
    public class NeosVMDImporter : NeosMod
    {
        public override string Name => "NeosVMDImporter";
        public override string Author => "sjsanjsrh";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/sjsanjsrh/NeosVMDImporter";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("com.Sinduy.NeosVMDImporter");
            harmony.PatchAll();
        }

        [HarmonyPatch(typeof(UniversalImporter), "ImportTask", new Type[] { typeof(AssetClass), typeof(IEnumerable<string>), typeof(World), typeof(float3), typeof(floatQ), typeof(float3), typeof(bool) })]
        class Patch
        {
            public static bool Prefix()
            {
                return false;
            }
        }
    }
}