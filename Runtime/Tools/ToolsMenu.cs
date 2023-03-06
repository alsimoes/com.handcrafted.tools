using System.IO;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace Handcrafted
{
    public static class ToolsMenu 
    {
        [MenuItem("Handcrafted/Tools/Create Default Folders")]
        public static void CreateDefaultFoldersMenu()
        {
            CreateDefaultFolders("_Project", "Script", "Art", "Scenes", "Prefabs", "Sound");
            Refresh();
        }

        public static void CreateDefaultFolders(string root, params string[] dirs)
        {
            var fullPath = Combine(dataPath, root);

            foreach (var dir in dirs)
            {
                CreateDirectory(Combine(fullPath, dir));
            }
        }
    }
}
