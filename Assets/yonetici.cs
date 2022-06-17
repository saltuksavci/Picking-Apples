using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;



public class yonetici : MonoBehaviour

{      
    public TMPro.TextMeshProUGUI puan_txt;
    public Rigidbody rb;
    public Rigidbody rb_can;
    public GameObject elma;
    public GameObject heart; 
    public GameObject bomba;
    public GameObject contine_btn;
    public GameObject pause_btn;
    public GameObject game_over;        
    
    public GameObject contine_panel;
    public GameObject kasa;
    public GameObject kasa1;
    public GameObject kasa2;
    public GameObject kasa3;
    public GameObject kasa4;
    private sepet skor1;
    private GameObject skoru_getir;
 
    public int a;
    
    public float elma_ekleme_hizi;

    public Button adlife;
    private InterstitialAd reklamObjesi;
    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("elma_ekle", 0.0f, elma_ekleme_hizi);
        InvokeRepeating("can_ekle", 0.0f, 5.0f);
        InvokeRepeating("bomba_ekle", 0.0f, 5.0f);
    }
    // Update is called once per frame
    void Update()
    {
        elma_eklme_hiz_cod();       
        a = GameObject.Find("valde").GetComponent < sepet >().skor;
        elma_kasalari();
       /* 
        if (!reklamObjesi.IsLoaded())
        {
            adlife.interactable = true;

        }
        else
        {
            adlife.interactable = false;
        }*/
    }
    public void elma_eklme_hiz_cod()
    {
        if (a > 0)
        {
            elma_ekleme_hizi = 0.9f;
            rb.drag = 1.5f;
            rb_can.drag = 2f;
            if (a > 100)
            {
                elma_ekleme_hizi = 0.8f;
                rb.drag = 0.8f;
                rb_can.drag = 1.5f;
                if (a > 500)
                {
                    elma_ekleme_hizi = 0.2f;
                    rb.drag = 0.5f;
                    rb_can.drag = 1f;
                    if (a > 1000)
                    {
                        elma_ekleme_hizi = 0.05f;
                        rb.drag = 0.2f;
                        rb_can.drag = 0.5f;
                        if (a > 2000)
                        {
                            elma_ekleme_hizi = 0.01f;
                            rb.drag = 0f;
                            rb_can.drag = 0f;
                        }
                    }
                }
            }
        }
    }
    //elma kasaları kodları
    public void elma_kasalari()
    {        
        if (a > 100)            
        {           
            kasa.SetActive(true);
            if (a > 500)
            {                
                kasa1.SetActive(true);
                if (a > 1000)
                {                    
                    kasa2.SetActive(true);
                    if (a > 1500)
                    {                        
                        kasa3.SetActive(true);
                        if (a > 2000)
                        {                            
                            kasa4.SetActive(true);
                        }
                    }
                }
            }
        }       
    }
    //main manü ekranı buton kodları
    public void play()
    {        
        contine_panel.SetActive(false);
        pause_btn.SetActive(true);
        Time.timeScale = 1.0f;
    }

    //oyun ekranındaki play butonu
    //--------------------------------------------
    public void game_pause_btn()
    {        
        contine_panel.SetActive(true);
        pause_btn.SetActive(false);
        Time.timeScale = 0.0f;
    }   
    public void contine()
    {
        contine_panel.SetActive(false);
        pause_btn.SetActive(true);
        Time.timeScale = 1.0f;
    }
    //--------------------------------------------
    //oyunda ölünce gelen ekran butonları
    public void replay_btn()
    {     
        game_over.SetActive(false);
        SceneManager.LoadScene("Scenes/elma_toplama");        
    }
    public void menubtn()
    {        
        SceneManager.LoadScene("Scenes/main");
        game_over.SetActive(false);
    }
    void can_ekle()
    {
        float rast = Random.Range(6.5f, 0.9f);
        GameObject yeni_heart = Instantiate(heart, new Vector3(rast, 11.22f, 1.55f), Quaternion.identity);        
    }
    void bomba_ekle()
    {
        float rast = Random.Range(7f, 0f);
        GameObject yeni_bomba = Instantiate(bomba, new Vector3(rast, 11.22f, 1.55f), Quaternion.identity);
    }
    void elma_ekle()
    {
        float rast = Random.Range(7.5f, 0.3f);
        GameObject yeni_elma = Instantiate(elma, new Vector3(rast, 11.22f, 1.55f),Quaternion.identity);
    }
    public void reklam_can_ekle()
    {
            Time.timeScale = 1.0f;
            game_over.SetActive(false);
            pause_btn.SetActive(true);
            GameObject.Find("yer").GetComponent<zemin>().can_artiyor = true;
            Time.timeScale = 1.0f;        
    }    
}