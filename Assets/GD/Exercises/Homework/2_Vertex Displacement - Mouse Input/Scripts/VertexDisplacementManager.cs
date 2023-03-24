using GD.Selection;
using UnityEngine;

public class VertexDisplacementManager : MonoBehaviour
{
    private IRayProvider rayProvider;
    private ISelector selector;
    private ISelectionResponse selectionResponse;
    private Transform currentSelection;
    private RaycastHit currentSelectionHitInfo;
    private bool bMouseDrag;

    private void Awake()
    {
        rayProvider = GetComponent<IRayProvider>();
        selector = GetComponent<ISelector>();
        selectionResponse = GetComponent<ISelectionResponse>();
    }

    // Update is called once per frame
    private void Update()
    {
        //if (currentSelection != null)
        //{
        //    selectionResponse.OnDeselect(currentSelection);
        //}

        selector.Check(rayProvider.CreateRay());
        currentSelection = selector.GetSelection();
        currentSelectionHitInfo = selector.GetHitInfo();

        if (currentSelection != null)
        {
            selectionResponse.OnSelect(currentSelection, currentSelectionHitInfo);
        }
    }
}