using UnityEditor;
using UnityEngine;

namespace EditorAssistant
{
    internal class EditorQuickOptions : MonoBehaviour
    {
        [MenuItem("Tools/Toggle Domain and Scene Reloading")]
        public static void DisableReloading()
        {
            var enterPlayModeOption = EditorSettings.enterPlayModeOptions;
            if (enterPlayModeOption == EnterPlayModeOptions.None)
            {
                EditorSettings.enterPlayModeOptions = EnterPlayModeOptions.DisableDomainReload | EnterPlayModeOptions.DisableSceneReload;
                Debug.Log("Enter Play Mode Settings Updated: Domain/Scene Reloading Disabled");
            }
            else
            {
                EditorSettings.enterPlayModeOptions = EnterPlayModeOptions.None;
                Debug.Log("Enter Play Mode Settings Updated: Domain/Scene Reloading Enabled");
            }
            AssetDatabase.SaveAssets();
        }

    }
}
