using UnityEditor;
using UnityEngine;
using dev.hrpnx.back_lit_menu_for_modular_avatar.runtime;

namespace dev.hrpnx.back_lit_menu_for_modular_avatar.editor
{
    public class MenuItem : MonoBehaviour
    {
        [UnityEditor.MenuItem("GameObject/Modular Avatar/Add Back Lit Menu Installer", false, 0)]
        public static void Create()
        {
            var avatarRoot = Selection.activeGameObject;
            // TODO: Validate that avatarRoot is indeed the avatar root game object

            var menuInstallerName = "BackLitMenuInstaller";
            var existingMenuInstaller = avatarRoot.transform.Find(menuInstallerName);
            if (existingMenuInstaller != null && existingMenuInstaller.gameObject != null)
            {
                Debug.Log("installer already exists. so skipping creation.");
                return;
            }

            var menuInstaller = new GameObject(menuInstallerName);
            menuInstaller.transform.SetParent(avatarRoot.transform);
            var component = menuInstaller.AddComponent<BackLitMenuInstaller>();
            component.Color = new Color(12, 12, 12, 1);
            component.MainStrength = 0.5f;
            component.NormalStrength = 1;
            component.Border = 0.6f;
            component.Blur = 0.2f;
            component.Directivity = 10;
            component.ViewStrength = 1;
        }
    }
}
