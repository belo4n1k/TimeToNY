using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CameraShtun : MonoBehaviour
{
    public VideoPlayer TvPlayer;
    public VideoClip[] clip;
    [SerializeField] private float m_Speed, m_Ampl;
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0 , Mathf.Sin(Time.time * m_Speed) * m_Ampl, 0));

        if (Input.GetKeyDown(KeyCode.K))
        {
            TvPlayer.clip = clip[Random.Range(0, clip.Length)];
        }
    }
}
