using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kosu_sepet : MonoBehaviour
{
    public TMPro.TextMeshProUGUI puan_txt;
    public TMPro.TextMeshProUGUI elma_sayisi_txt;
    public TMPro.TextMeshProUGUI game_o_p_puan_txt;
    public TMPro.TextMeshProUGUI main_manu_devam_skor_txt;    
    public AudioSource sepet_ses;
    public int elma_sayisi=0;
    public int skor = 0;
    int kosu_yuksekskor;
    public bool miknatis_alindi = false;
    public GameObject miknatis_res;

    private void Start()

    {
        if (!PlayerPrefs.HasKey("hicscore_kosu"))
        {
            PlayerPrefs.SetInt("hicscore_kosu", 0);
            main_manu_devam_skor_txt.text = kosu_yuksekskor.ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "elma")
        {
            skor += 10;
            elma_sayisi +=1;
           
            sepet_ses.Play();

            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "miknatis")
        {
            GameObject[] tum_miknatislar = GameObject.FindGameObjectsWithTag("miknatis");
            foreach (GameObject miknatis in tum_miknatislar)
            {
                Destroy(miknatis);
                miknatis_alindi = true;
                miknatis_res.SetActive(true);
                Invoke("miknatisi_resetle", 5.0f);

            }
            miknatis_alindi = true;
            Invoke("miknatisi_resetle", 5.0f);
        }        
    }
    void miknatisi_resetle()
    {
        miknatis_res.SetActive(false);
        miknatis_alindi = false;
    }
    void Update()
    {
        main_manu_devam_skor_txt.text = kosu_yuksekskor.ToString();
        if (PlayerPrefs.HasKey("hicscore_kosu"))
        {
            kosu_yuksekskor = PlayerPrefs.GetInt("hicscore_kosu");
            if (kosu_yuksekskor < skor)
            {
                PlayerPrefs.SetInt("hicscore_kosu", skor);
                main_manu_devam_skor_txt.text = kosu_yuksekskor.ToString();
            }
        }        
        puan_txt.text = skor.ToString("");
        elma_sayisi_txt.text = elma_sayisi.ToString("");
        game_o_p_puan_txt.text = skor.ToString("");
    }
}
