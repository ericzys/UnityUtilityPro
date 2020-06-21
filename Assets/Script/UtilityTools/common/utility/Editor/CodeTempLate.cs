using UnityEngine;
using System.Collections;
using System.IO;
namespace EditorExtension
{
    public class CodeTempLate 
    {
        public static void Write(StreamWriter _write,string gameName)
        {
            _write.WriteLine("using UnityEngine;");
            _write.WriteLine("using System.Collections;");
            _write.WriteLine();
            _write.WriteLine($"public class {gameName} : MonoBehaviour");
            _write.WriteLine("{");
            _write.WriteLine();
            _write.WriteLine("}");

        }
    }
}

