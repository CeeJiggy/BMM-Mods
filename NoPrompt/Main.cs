using System;
using System.Collections.Generic;
using Flash2;
using UnhollowerRuntimeLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PromptDisabler
{
    public static class Main
    {
        private static PromptDisabler _promptDisabler;
        private static CameraController _cameraController;

        public static List<Type> OnModLoad(Dictionary<string, object> settings)
        {
            return new List<Type> { typeof(PromptDisabler) };
        }

        public static void OnModUpdate()
        {
            var player = Object.FindObjectOfType<Player>();
            if (player == null)
            {
                Object.Destroy(_promptDisabler);
                _promptDisabler = null;
                return;
            }

            if (player != null)
            {
                if (_promptDisabler == null)
                {
                    _cameraController = player.GetCameraController();
                    _promptDisabler = new PromptDisabler(_cameraController.gameObject.AddComponent(Il2CppType.Of<PromptDisabler>()).Pointer);
                }
            }
        }
    }
}