using UnityEditor;

namespace UnityTDDHelper
{
    
    public class ClassRepresentationWindow : EditorWindow
    {

        [MenuItem("UnityTDDPackage/Class Representation Window")]
        static void ShowWindow()
        {
            GetWindow<ClassRepresentationWindow>("Class Representation Window");
        }
        
        private void OnGUI()
        {

        }

    }
}

