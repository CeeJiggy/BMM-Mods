using System;
using Flash2;
using Framework.UI;
using UnityEngine;

namespace SkipReplay
{
    internal class SkipReplay : MonoBehaviour
    {
        public SkipReplay(IntPtr value) : base(value) { }

        private void Start()
        {
            MainGame.s_Instance.m_ReplayParam.FalloutReplayTime = 0f;
            MainGame.s_Instance.m_ReplayParam.FalloutReplayRounds = 0;
        }
    }
}