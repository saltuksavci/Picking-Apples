using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zemin : MonoBehaviour
{ 
    float can=100.0f;
    public float su_anki_can = 100.0f;
    public Image can_bari;
    public GameObject game_over;
    public GameObject pause_btn;    
    public bool can_artiyor;
    public ParticleSystem can_ptc_stm; 
    void Update()
    {
        if (can_artiyor)
        {
            if(su_anki_can<100.0f)
            {
                su_anki_can = 100.0f;
                can_ptc_stm.Play();
                can_artiyor =false;
            }            
        }        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heart")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "bomba")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "elma")
        {
            Destroy(other.gameObject);
            //can azaltma
            su_anki_can -= 10.0f;
            can_bari.fillAmount = su_anki_can / can;            
            if(su_anki_can<=0)
            {
                game_over.SetActive(true);
                pause_btn.SetActive(false);
                Time.timeScale = 0.0f;                
            }
        }
    }
}
        
   

