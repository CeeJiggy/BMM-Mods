using System;
using System.Collections.Generic;
using Flash2;
using UnhollowerRuntimeLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace SkipReplay
{
    public static class Main
    {
        private static CameraController _cameraController;
        private static SkipReplay _skipReplay;
        
        public static List<Type> OnModLoad(Dictionary<string, object> settings)
        {
            return new List<Type> { typeof(SkipReplay) };
        }

        public static void OnModUpdate()
        {
            var player = Object.FindObjectOfType<Player>();
            if (player == null)
            {
                Object.Destroy(_skipReplay);
                _skipReplay = null;
                return;
            }

            if (player != null)
            {
                if (_skipReplay == null)
                {
                    _cameraController = player.GetCameraController();
                    _skipReplay = new SkipReplay(_cameraController.gameObject.AddComponent(Il2CppType.Of<SkipReplay>()).Pointer);
                }
            }
        }
    }
}