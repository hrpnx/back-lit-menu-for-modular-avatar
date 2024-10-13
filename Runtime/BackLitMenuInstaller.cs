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
        public VRCExpressionsMenu RootMenu;
    }
}
