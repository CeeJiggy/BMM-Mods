using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Flash2;
using Steamworks;
using UnhollowerRuntimeLib;

namespace CustomButtonUI
{
    internal class CustomButtonUI : MonoBehaviour
    {
        public CustomButtonUI(IntPtr value) : base(value) { }
        public GameParam.PlatformUserInterface controller = GameParam.PlatformUserInterface.XboxSeriesXController;
        public void Awake()
        {
            GameParam.platformUserInterface = controller;
        }

        public void Update()
        {
            Reassign();
        }

        public void Reassign()
        {
            GameParam.platformUserInterface = controller;
        }
    }
}
