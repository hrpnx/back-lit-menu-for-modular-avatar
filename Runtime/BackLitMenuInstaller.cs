using UnityEngine;
using VRC.SDKBase;
using System.Collections.Generic;
using VRC.SDK3.Avatars.ScriptableObjects;

namespace dev.hrpnx.back_lit_menu_for_modular_avatar.runtime
{
    public class BackLitMenuInstaller : MonoBehaviour, IEditorOnly
    {
        public List<Material> Exclusions;
        public bool Default;
        public bool Saved;
        [ColorUsage(true, true)]
        public Color Color;
        [CustomLabel("メインカラーの強度"), Range(0, 1)]
        public float MainStrength;
        [CustomLabel("ノーマルマップ強度"), Range(0, 1)]
        public float NormalStrength;
        [CustomLabel("範囲"), Range(0, 1)]
        public float Border;
        [CustomLabel("ぼかし"), Range(0, 1)]
        public float Blur;
        [CustomLabel("指向性")]
        public float Directivity;
        [CustomLabel("ぼかし"), Range(0, 1)]
        public float ViewStrength;
        public VRCExpressionsMenu RootMenu;
        public bool AnimationWriteDefault = false;
    }
}
