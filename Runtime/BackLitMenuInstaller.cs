using UnityEngine;
using VRC.SDKBase;

namespace dev.hrpnx.back_lit_menu_for_modular_avatar.runtime
{
    public class BackLitMenuInstaller : MonoBehaviour, IEditorOnly
    {
        public Color Color;
        public float NormalStrength;
        public float Border;
        public float Blur;
        public float FresnelPower;
        public bool Default;
        public bool Saved;
    }
}
