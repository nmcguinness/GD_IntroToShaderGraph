using UnityEngine;

public class SunDirectionSetter : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer surfaceMeshRenderer;

    [SerializeField]
    private Light sunLight;

    private int sunDirectionID;
    private Material surfaceMaterial;

    private void Start()
    {
        //get hash of the reference in the shader
        sunDirectionID = Shader.PropertyToID("_Sun_Direction");

        //get surface material
        surfaceMaterial = surfaceMeshRenderer.GetComponent<Material>();
    }

    private void Update()
    {
        if (surfaceMaterial == null) return;
        if (sunLight == null) return;

        //use hash rather than reference name to speed up setting each update
        surfaceMaterial.SetVector(sunDirectionID, sunLight.transform.forward);
        // surfaceMaterial.SetVector("_Sun_Direction", sunLight.transform.forward);
    }
}