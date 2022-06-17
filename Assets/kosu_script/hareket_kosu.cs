using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket_kosu : MonoBehaviour
{
    public float Hiz;    
    public Rigidbody rb;
    float oyuncu_hrkt;
   
    



    public Animator animasyon;
    public bool havada;
    private void Start()
    {
     //   havada = true;
    }
    private void FixedUpdate()
    {
        oyuncu_hareketi();
       
        
    }
 
    void oyuncu_hareketi()
    {
       
            oyuncu_hrkt = SimpleInput.GetAxis("Horizontal");

            rb.AddForce(-Vector3.right * Hiz * oyuncu_hrkt);
           //  rb.velocity = (-Vector3.right * Hiz) * oyuncu_hrkt * Time.deltaTime;
       


    }
   
    


}
