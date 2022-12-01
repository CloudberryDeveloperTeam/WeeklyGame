using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolHandler : MonoBehaviour
{
    public GameObject testPos;
    
    public Vector3 mousePosition;
    Quaternion m_MyQuaternion;
    
    void Start()
    {
        m_MyQuaternion = new Quaternion();
    }


    void Update()
    {
        mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        m_MyQuaternion.SetFromToRotation(transform.position, testPos.transform.position);
        transform.rotation = m_MyQuaternion;
    }
}
