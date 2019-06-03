using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public bool clicked;
    private MeshRenderer rend;
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (!clicked)
            {
                rend.sharedMaterial.color = Color.blue;
                clicked = true;
            }
            else
            {
                rend.sharedMaterial.color = Color.red;
                clicked = false;
            }
        }
    }
}
