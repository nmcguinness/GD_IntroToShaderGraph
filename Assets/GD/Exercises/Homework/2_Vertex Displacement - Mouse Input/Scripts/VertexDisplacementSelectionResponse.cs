using UnityEngine;

namespace GD.Selection
{
    public class VertexDisplacementSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private Material material;

        private int distortionCentreID;
        private int displaceVerticesID;

        // Start is called before the first frame update
        private void Start()
        {
            distortionCentreID = Shader.PropertyToID("_Distortion_Centre");
        }

        void ISelectionResponse.OnSelect(Transform transform, RaycastHit hitInfo)
        {
            if (material == null)
                return;

            material.SetVector(distortionCentreID, hitInfo.point);
            //   transform.InverseTransformPoint(hitInfo.point));

            //           material.SetVector("_Distortion_Centre", new Vector3(0, 10, 20));
        }

        void ISelectionResponse.OnDeselect(Transform transform)
        {
            //if (material == null)
            //    return;
        }
    }
}