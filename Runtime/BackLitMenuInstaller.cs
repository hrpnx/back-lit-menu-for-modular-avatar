using UnityEngine;
using VRC.SDKBase;
using System.Collections.Generic;

namespace dev.hrpnx.back_lit_menu_for_modular_avatar.runtime
{
    public class BackLitMenuInstaller : MonoBehaviour, IEditorOnly
    {
        public List<Material> Exclusions;
        public bool Default;
        public bool Saved;
    }
}
