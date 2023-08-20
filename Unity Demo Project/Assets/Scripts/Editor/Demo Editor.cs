using NKStudio;
using UnityEditor;

public class DemoEditorCode : Editor
{
    [MenuItem("Tools/Test")]
    private static void Test()
    {
        MacUtility.UseDemo();
    }
}
