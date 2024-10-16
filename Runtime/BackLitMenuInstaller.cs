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
        public float MainStrength;
        public float NormalStrength;
        public float Border;
        public float Blur;
        public float Directivity;
        public float ViewStrength;
        public VRCExpressionsMenu RootMenu;
    }
}
