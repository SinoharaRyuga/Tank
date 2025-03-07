﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    [SerializeField] GameManager m_gameManager = default;
    [SerializeField] bool m_fallFlag = true;
    [SerializeField] float m_falltime = 0;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (m_fallFlag)
        {
            if (m_gameManager.m_moveFlag && collision.gameObject.tag == "PlayerTank")
            {
                this.GetComponent<Renderer>().material.color = Color.black;
                Destroy(this.gameObject, m_falltime);
            }
        }
    }
}
