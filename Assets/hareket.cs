using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{    
    public float Hiz=50;    
    public Rigidbody rb;
    float oyuncu_hrkt;
    private void FixedUpdate()
    {
        oyuncu_hareketi();    
    }
    void oyuncu_hareketi()
    {
            oyuncu_hrkt = SimpleInput.GetAxis("Horizontal");
            rb.velocity = (-Vector3.right * Hiz) * oyuncu_hrkt * Time.deltaTime;      
    }
  

}
