using UnityEngine;

/// <summary>
/// Add a GUI prompt to a demo or prototype
/// </summary>
/// <see cref="https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
public class UIRichTextPrompt : MonoBehaviour
{
    [Header("Rich Text Content")]
    [SerializeField]
    [TextArea(1, 4)]
    private string text = "<b><size=18><color=white>Sample emboldened and coloured text</color></size></b>";

    [Header("Onscreen Position")]
    [SerializeField]
    private Rect textPosition = new Rect(20, 20, 200, 20);

    private GUIStyle guiStyle;

    private void Start()
    {
        guiStyle = new GUIStyle();
        guiStyle.richText = true;
        text = text.Trim();
    }

    private void OnGUI()
    {
        GUI.Label(textPosition, text, guiStyle);
    }
}