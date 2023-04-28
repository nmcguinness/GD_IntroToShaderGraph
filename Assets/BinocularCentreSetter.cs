using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinocularCentreSetter : MonoBehaviour
{
    [SerializeField]
    private Material material;

    private int leftID;

    private void Start()
    {
        //get hash of the reference in the shader
        leftID = Shader.PropertyToID("_Left");
    }

    private void Update()
    {
        if (material == null) return;

        var x = Input.mousePosition.x / Screen.width - 0.2f - 0.5f;
        var y = Input.mousePosition.y / Screen.height - 0.5f;

        material.SetVector(leftID, new Vector2(x, y));
    }
}