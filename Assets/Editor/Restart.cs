using System;
using System.Reflection;
using UnityEditor;

public class Restart : Editor
{
    [MenuItem("Assets/Restart", false, 40)]
    private static void ReStart()
    {
        RestartEditorAndRecompileScripts();
    }

    private static void RestartEditorAndRecompileScripts(bool dryRun = false)
    {
        var editorApplicationType = typeof(EditorApplication);
        var restartEditorAndRecompileScripts =
            editorApplicationType.GetMethod("RestartEditorAndRecompileScripts",
                BindingFlags.NonPublic | BindingFlags.Static);
        if (!dryRun)
        {
            if (restartEditorAndRecompileScripts != null)
                restartEditorAndRecompileScripts.Invoke(null, null);
        }
        else if (restartEditorAndRecompileScripts == null)
            throw new MissingMethodException(editorApplicationType.FullName, "RestartEditorAndRecompileScripts");
    }
}
