using UnityEngine;

public class SimpleThirdPersonCameraController : MonoBehaviour
{
    [SerializeField]
    private Transform cameraTarget;

    [SerializeField]
    private Transform cameraParent;

    [SerializeField]
    [Range(0.1f, 5)]
    private float orbitSpeed = 1;

    private float mouseX;
    private float mouseY;

    //u,l,u,l,u,l
    //u,u,l,u,u,u,l

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }

    private void FixedUpdate()
    {
        //camera - Y
        transform.Rotate(0, mouseX * orbitSpeed, 0);
        //camera - x
        cameraParent.Rotate(-mouseY * orbitSpeed, 0, 0);

        //move to the target position
        transform.position = cameraTarget.position;
    }
}