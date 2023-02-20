using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    
    Transform m_Camera;

    void Start()
    {
        m_Camera = Camera.main.transform;
    }


    void Update()
    {
        transform.rotation = m_Camera.rotation;
    }
}

