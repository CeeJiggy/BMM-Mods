using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Flash2;
using UnhollowerRuntimeLib;


namespace CharacterSounds
{
    public static class Main
    {
        private static CharacterSounds _characterSounds;
        public static List<Type> OnModLoad(Dictionary<string, object> settings)
        {
            return new List<Type> { typeof(CharacterSounds) };
        }

        public static void OnModUpdate()
        {
            if (GameManager.Instance.gameObject != null && _characterSounds == null && AppScene.GetActive() == AppScene.eID.Title)
            {
               _characterSounds = new CharacterSounds(GameManager.Instance.gameObject.AddComponent(Il2CppType.Of<CharacterSounds>()).Pointer);
            }           
        }
    }
}
