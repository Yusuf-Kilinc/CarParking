using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Car Controller")]
    public GameObject[] Arabalar;
    public GameObject[] ArabaCanvasGrsl;
    public Sprite AracGeldiGrsl;
    int ActiveCarIndex = 0;
    public int KacAraba;
    int KalanAracSayitext;
    public TextMeshProUGUI KalanAracSayi;

    [Header("Platform Ayarlari")]
    public GameObject Platform_1;
    public GameObject Platform_2;
    public float[] DonusHizlari;
    public GameObject DurusNoktasi;

    private void Start()
    {
      /*  KalanAracSayitext = KacAraba;
        KalanAracSayi.text = KalanAracSayitext.ToString();
        for (int i = 0; i < KacAraba; i++)
        {
            ArabaCanvasGrsl[i].SetActive(true);
        }*/
    }

    public void YeniArabaGetir()
    {
        DurusNoktasi.SetActive(true);
        if (ActiveCarIndex < KacAraba)
        {
            Arabalar[ActiveCarIndex].SetActive(true);
        }
    /*    ArabaCanvasGrsl[ActiveCarIndex - 1].GetComponent<Image>().sprite = AracGeldiGrsl;
        KalanAracSayitext--;
        KalanAracSayi.text = KalanAracSayitext.ToString();*/
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Arabalar[ActiveCarIndex].GetComponent<Araba>().ilerle = true;
            ActiveCarIndex++;
        }
        Platform_1.transform.Rotate(new Vector3(0, 0, DonusHizlari[0]), Space.Self);
    }
}
