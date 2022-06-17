using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepet : MonoBehaviour
{
    public TMPro.TextMeshProUGUI puan_txt;
    public TMPro.TextMeshProUGUI game_o_p_puan_txt;  
    public TMPro.TextMeshProUGUI main_manu_devam_skor_txt;
    public ParticleSystem sepet_ptc_stm;
    public AudioSource sepet_ses;
    public AudioSource bomba_sound;
    public ParticleSystem bomba_ptc_stm;
    public int skor = 0;
    int yuksekskor;
    private void Start()

    {
        if (!PlayerPrefs.HasKey("hicscore"))
        {            
                PlayerPrefs.SetInt("hicscore", 0);
                main_manu_devam_skor_txt.text = yuksekskor.ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heart")
        {                    
            Destroy(other.gameObject);           
            GameObject.Find("yer").GetComponent<zemin>().can_artiyor= true;
        }
        if (other.gameObject.tag == "bomba")
        {
            bomba_ptc_stm.Play();
            bomba_sound.Play();
            GameObject.Find("yer").GetComponent<zemin>().su_anki_can = GameObject.Find("yer").GetComponent<zemin>().su_anki_can - 25;         
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "elma")
        {
            skor += 10;
            sepet_ptc_stm.Play();
            sepet_ses.Play();
            Destroy(other.gameObject); 
        }
    }
    // Update is called once per frame
    void Update()
    {        
        main_manu_devam_skor_txt.text = yuksekskor.ToString();        
        if (PlayerPrefs.HasKey("hicscore"))
        { 
            yuksekskor = PlayerPrefs.GetInt("hicscore");
             if (yuksekskor<skor)
             { 
                PlayerPrefs.SetInt("hicscore", skor);
                main_manu_devam_skor_txt.text = yuksekskor.ToString();                
            }          
        }        
        puan_txt.text = skor.ToString("");
        game_o_p_puan_txt.text = skor.ToString("");       
    }
}