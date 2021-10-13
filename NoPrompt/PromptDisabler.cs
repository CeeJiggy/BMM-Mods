using System;
using System.IO;
using System.Reflection;
using Flash2;
using Framework.UI;
using UnityEngine;

namespace PromptDisabler
{
    internal class PromptDisabler : MonoBehaviour
    {
        public PromptDisabler(IntPtr value) : base(value) { }

        private MainGameStage stage;

        public void Update()
        {
            if (stage == null)
            {
                stage = FindObjectOfType<MainGameStage>();
            }
            if (stage == null || stage.m_IsAssistConfirmed) return;
            stage.m_IsAssistConfirmed = true;
        }
    }
}