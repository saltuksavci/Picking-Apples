using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yolhareket : MonoBehaviour
{    
    public GameObject bitti_pnl;        
    public float hiz;   
    public GameObject yol;
    public GameObject yol1;
    public GameObject yol2;
    public Transform yol_trans;
    public Transform yol1_trans;
    public Transform yol2_trans;
    public Transform yol_bas_kup;
    
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "yol_son")
        {

            yol2_trans.position = yol_bas_kup.position;
        }
        if (other.gameObject.name == "yol_son1")
        {
            yol_trans.position = yol_bas_kup.position;
        }
        if (other.gameObject.name == "yol_son2")
        {
            yol1_trans.position = yol_bas_kup.position;
        }
        if (other.gameObject.tag == "engel")
        {
            bitti_pnl.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    private void FixedUpdate()
    {
        hareket();
    }
    void hareket()
    {
        if (hiz <= 40)
        {
            hiz += Time.deltaTime * 0.5f;            
        }
        yol.transform.Translate(0, 0, hiz * Time.deltaTime);
        yol1.transform.Translate(0, 0, hiz * Time.deltaTime);
        yol2.transform.Translate(0, 0, hiz * Time.deltaTime);
  
    }


}
