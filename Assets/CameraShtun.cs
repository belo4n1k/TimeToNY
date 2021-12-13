using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShtun : MonoBehaviour
{
    [SerializeField] private float m_Speed, m_Ampl;
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0 , Mathf.Sin(Time.time * m_Speed) * m_Ampl, 0));
    }
}
