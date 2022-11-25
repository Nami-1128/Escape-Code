using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarBaldosas : MonoBehaviour
{
    protected int actualNumber;
    protected int baldosaCode;
    public GameObject bot;

    protected void ComprovateNumber()
    {
        void OnCollisionEnter(Collider collision)
        {
            if(collision.gameObject == bot)
            {
                actualNumber += 1;
            }
        }
    }
}
