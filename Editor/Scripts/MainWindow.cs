using UnityEditor;
using UnityEngine;
using System.IO;

namespace UnityTDDHelper
{

    public class MainWindow : EditorWindow
    {
        string workFolder = "";//"Assets/unity-tdd-helper/";
        string workFolderInput = "put path in here relative to project path";
        ClassRepresentation classRepresentation;

        [MenuItem("UnityTDDPackage/Open Main Window")]
        static void ShowWindow()
        {
            GetWindow<MainWindow>("Open Main Window");
        }

        private void OnGUI()
        {
            if (workFolder == "")
            {
                
                workFolderInput =  GUILayout.TextField(workFolderInput);

                if (GUILayout.Button("Set Workfolder"))
                {
                    if (Directory.Exists(workFolderInput))
                    {
                        workFolder = workFolderInput;

                    }
                }
            }
            else
            {
                string configPath = workFolderInput+"architecture-planned.yml";
                string keywordPath = workFolderInput+"template-keywords.yml";
                if (File.Exists(configPath) && File.Exists(keywordPath))
                {
                    ClassBuilder classBuilder = new ClassBuilder(configPath,keywordPath);

                    //classRepresentation = classBuilder.GetClassRepresentation()
                }
            }

        }

    }
}

