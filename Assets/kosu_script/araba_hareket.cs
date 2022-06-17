using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba_hareket : MonoBehaviour
{
    public float hiz1;
    public Transform a;
    void Update()
    {
        hiz1 = GameObject.Find("MaleFreeSimpleMovement1").GetComponent<yolhareket>().hiz;
        a.transform.Translate(0, 0, hiz1 *3* Time.deltaTime);
    }
}
