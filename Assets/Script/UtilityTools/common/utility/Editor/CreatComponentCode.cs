using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;

namespace EditorExtension
{
    public class CreatComponentCode : MonoBehaviour
    {
        [MenuItem(itemName:"GameObject/@EditorExtension-CreatCode",isValidateFunction:false,0)]
        static void CreatCode()
        {
            var _gameobject = Selection.objects.First();
            //创建脚本
            var scriptFolder = Application.dataPath + "/Script/app";
            //创建脚本路劲
            if (!Directory.Exists(scriptFolder))
                Directory.CreateDirectory(scriptFolder);
            //创建脚本
            var scriptfile = scriptFolder + $"/{_gameobject.name}.cs";
            var stream = File.CreateText(scriptfile);
            CodeTempLate.Write(stream, _gameobject.name);
            stream.Close();
            AssetDatabase.Refresh();

        }
    }
}

