using System;
using System.Collections.Generic;
using Harmony;
using Hmx.Audio;
using MelonLoader;
using UnityEngine;

namespace AudicaModding
{
    public class AudicaMod : MelonMod
    {
        public static class BuildInfo
        {
            public const string Name = "MineSoundDisabler";  // Name of the Mod.  (MUST BE SET)
            public const string Author = "MeepsKitten"; // Author of the Mod.  (Set as null if none)
            public const string Company = null; // Company that made the Mod.  (Set as null if none)
            public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
            public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
        }
        //intercept sounds
        [HarmonyPatch(typeof(KataUtil), "PlayFMODEvent", new Type[] { typeof(string), typeof(UAudioEmitterCom) })]
        private static class InterceptSounds
        {
            private static bool Prefix(KataUtil __instance, string eventName, UAudioEmitterCom emitter)
            {
                if (eventName == "event:/gameplay/dodge_success")
                {
                    return false;
                }
                else return true;
            }

        }
    }
}



