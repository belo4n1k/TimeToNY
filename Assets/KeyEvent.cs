using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyEvent : MonoBehaviour
{
    bool inHouse = false;
    public Animator anim;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Relocate();
        }
    }

    void Relocate()
    {
        anim.SetBool("In", !anim.GetBool("In"));
    }
}
