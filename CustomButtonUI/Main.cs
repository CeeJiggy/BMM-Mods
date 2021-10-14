using System;
using System.Collections.Generic;
using Flash2;
using UnhollowerRuntimeLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CustomButtonUI
{
    public static class Main
    {
        private static CustomButtonUI customButtonUI;
        public static List<Type> OnModLoad(Dictionary<string, object> settings)
        {
            return new List<Type> { typeof(CustomButtonUI) };
        }

        public static void OnModUpdate()
        {
            if (GameManager.Instance.gameObject != null && AppScene.GetActive() == AppScene.eID.SegaLogo && customButtonUI == null)
            {
                customButtonUI = new CustomButtonUI(GameManager.Instance.gameObject.AddComponent(Il2CppType.Of<CustomButtonUI>()).Pointer);
            }
        }
    }
}
