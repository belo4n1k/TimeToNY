using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SoundController : MonoBehaviour
{
   [SerializeField] private VideoPlayer m_Player;
   [SerializeField] private bool m_IsOn;
   private int m_Count;


   public void Mute()
   {
      Debug.Log("click");
      if (m_Count == 0)
      {
         m_Player.SetDirectAudioMute(0, true);
         m_Count++;
      }
      else
      {
         m_Player.SetDirectAudioMute(0, false);
         m_Count = 0;
      }
   }
}