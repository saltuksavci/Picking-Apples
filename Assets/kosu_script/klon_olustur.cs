using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klon_olustur : MonoBehaviour
{
    public GameObject elma;
    public GameObject jeep_sari;
    public GameObject jeep_yesil;
    public GameObject kutuk;
    public GameObject miknatis;
    public Transform oyuncu;
    float silinme_zamani = 20.0f;
    float sag_x_kordinat = 2.26f;
    float sol_x_kordinat = -2.13f;
    kosu_sepet cocuk;
    void Start()
    {
        InvokeRepeating("nesne_klonla", 0, 1f);
        InvokeRepeating("araba_klonla", 0, 0.5f);
        cocuk = GameObject.Find("MaleFreeSimpleMovement1").GetComponent<kosu_sepet>();
    }
    void araba_klonla()
    {
        int rastsayi = Random.Range(0, 100);     
        if (rastsayi > 0 && rastsayi < 9)
        {
            klonla(jeep_yesil, 1.5f);
        }      
        if (rastsayi > 80 && rastsayi < 90)
        {
            klonla(jeep_sari, 1.5f);
        }    
    }

    void nesne_klonla()
    {
        int rastsayi = Random.Range(0, 100);
        if (rastsayi > 10 && rastsayi < 75)
        {
            klonla(elma, 0.5f);
        }      
        if (rastsayi > 76 && rastsayi < 80)
        {
            klonla(kutuk, 0.5f);
        }    
        if (rastsayi > 95 && rastsayi < 100)
        {
            if (cocuk.miknatis_alindi==false)
            {
                klonla(miknatis, 1f);
            }            
        }
    }

    void klonla(GameObject nesne, float Y_kordinat)
    {
        GameObject yeni_klon = Instantiate(nesne);
        int rastsayi = Random.Range(0, 100);
        if (rastsayi < 50)
        {
            yeni_klon.transform.position = new Vector3(sag_x_kordinat, Y_kordinat, oyuncu.position.z + -160.0f);
        }
        else if (rastsayi > 50)
        {
            yeni_klon.transform.position = new Vector3(sol_x_kordinat, Y_kordinat, oyuncu.position.z + -160.0f);
        }
        Destroy(yeni_klon, silinme_zamani);
    }
}
