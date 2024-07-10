using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
{
    public bool ilerle;
    bool DurusNoktasiDurumu = false;
    public GameObject[] tekerizleri;
    public Transform parent;
    public GameManager manager;
    void Update()
    {
        if (!DurusNoktasiDurumu)
            transform.Translate(8f * Time.deltaTime * transform.forward);

        if (ilerle)
            transform.Translate(15f * Time.deltaTime * transform.forward);

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DurusNoktasý"))
        {
            DurusNoktasiDurumu = true;
            manager.DurusNoktasi.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Parking"))
        {
            ilerle = false;
            tekerizleri[0].SetActive(false);
            tekerizleri[1].SetActive(false);
            transform.SetParent(parent);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY |
                RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY |
                RigidbodyConstraints.FreezeRotationZ;
            manager.YeniArabaGetir();
        }
        else if (collision.gameObject.CompareTag("OrtaGobek"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Araba"))
        {
            Destroy(gameObject);
        }
    }
}
