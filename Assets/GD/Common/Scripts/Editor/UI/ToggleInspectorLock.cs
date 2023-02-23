using UnityEditor;

//NYC

/// <summary>
/// Add toggle for lock/unlock inspector window using Shift + L
/// </summary>
/// <see cref="https://www.programmersought.com/article/71125964072/"/>
public class ToggleInspectorLock
{
    [MenuItem("Tools/DKIT/UI/Toggle Inspector lock #l")]  //% = CTRL, # = SHIFT, l = shortcut alphanumberic key
    static public void Toggle()
    {
        var inspectorType = typeof(Editor).Assembly.GetType("UnityEditor.InspectorWindow");

        var isLocked = inspectorType.GetProperty("isLocked", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

        var inspectorWindow = EditorWindow.GetWindow(inspectorType);

        var state = isLocked.GetGetMethod().Invoke(inspectorWindow, new object[] { });

        isLocked.GetSetMethod().Invoke(inspectorWindow, new object[] { !(bool)state });
    }
}