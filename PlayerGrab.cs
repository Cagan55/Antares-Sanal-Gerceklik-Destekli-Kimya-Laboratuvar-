using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject hand;
    public GameObject el1;
    public GameObject el2;
    public GameObject balon;
    public GameObject joje;
    public GameObject mayer;
    public GameObject pipet;
    public GameObject tüp;
    public GameObject beher;
    public GameObject mezür;
    public GameObject periyodik;
    public GameObject bohr;
    public GameObject thomson;
    public GameObject dalton;
    public GameObject rutherford;
    public GameObject EldivenObj;
    public GameObject gozluk;
    public GameObject acildurum;
    public GameObject güvenlik;
    public GameObject sembol;
    public GameObject daltonimg;
    public GameObject rutherfordimg;
    public GameObject thomsonimg;
    public GameObject bohrimg;
    public GameObject aşındırıcı;
    public GameObject zehirli;
    public GameObject yanıcı;
    public GameObject yakıcı;
    public GameObject radyoaktif;
    public GameObject patlayıcı;
    public GameObject tahris;
    public GameObject zararlı;
    public GameObject SembolTab;

    public Material EldivenMat;

    private float focusTime;
    private float focusTime2;

    bool inHands = false;
    bool inHands2 = false;
    bool inHands3 = false;
    bool inHands4 = false;
    bool inHands5 = false;
    bool inHands6 = false;
    bool inHands7 = false;
    bool inHands8 = false;
    bool inHands9 = false;
    bool inHands10 = false;
    bool inHands11 = false;
    bool inHands12 = false;
    bool inHands13 = false;
    bool inHands14 = false;
    bool inHands15 = false;
    bool inHands16 = false;
    bool inHands17 = false;
    bool inHands18 = false;
    bool inHands19 = false;
    bool inHands20 = false;


    bool gözlük = false;
    bool eldiven = false;

    Vector3 balonPos;
    Vector3 jojePos;
    Vector3 mayerPos;
    Vector3 pipetPos;
    Vector3 tüpPos;
    Vector3 beherPos;
    Vector3 mezürPos;
    Vector3 bohrPos;
    Vector3 thompsonPos;
    Vector3 rutherfordPos;
    Vector3 acildurumPos;
    Vector3 daltonPos;
    Vector3 güvenlikPos;
    Vector3 aşındırıcıPos;
    Vector3 zehirliPos;
    Vector3 yanıcıPos;
    Vector3 yakıcıPos;
    Vector3 radyoaktifPos;
    Vector3 patlayıcıPos;
    Vector3 tahrisPos;
    Vector3 zararlıPos;

    Vector3 zararlıSca;
    Vector3 tahrisSca;
    Vector3 patlayıcıSca;
    Vector3 radyoaktifSca;
    Vector3 yakıcıSca;
    Vector3 yanıcıSca;
    Vector3 zehirliSca;
    Vector3 aşındırıcıSca;

    void Start()
    {
        balonPos = balon.transform.position;
        jojePos = joje.transform.position;
        mayerPos = mayer.transform.position;
        pipetPos = pipet.transform.position;
        tüpPos = tüp.transform.position;
        beherPos = beher.transform.position;
        mezürPos = mezür.transform.position;
        bohrPos = bohr.transform.position;
        thompsonPos = thomson.transform.position;
        rutherfordPos = rutherford.transform.position;
        daltonPos = dalton.transform.position;
        acildurumPos = acildurum.transform.position;
        güvenlikPos = güvenlik.transform.position;
        aşındırıcıPos = aşındırıcı.transform.position;
        zehirliPos = zehirli.transform.position;
        yanıcıPos = yanıcı.transform.position;
        yakıcıPos = yakıcı.transform.position;
        radyoaktifPos = radyoaktif.transform.position;
        patlayıcıPos = patlayıcı.transform.position;
        tahrisPos = tahris.transform.position;
        zararlıPos = zararlı.transform.position;

        zararlıSca = zararlı.transform.localScale;
        tahrisSca = tahris.transform.localScale;
        patlayıcıSca = patlayıcı.transform.localScale;
        radyoaktifSca = radyoaktif.transform.localScale;
        yakıcıSca = yakıcı.transform.localScale;
        yanıcıSca = yanıcı.transform.localScale;
        zehirliSca = zehirli.transform.localScale;
        aşındırıcıSca = aşındırıcı.transform.localScale;
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands && hit.transform.name == "Balon")
                {
                    balon.transform.SetParent(hand.transform);
                    balon.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    balon.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                    inHands = true;
                }
                else if (inHands)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    balon.transform.SetParent(null);
                    balon.transform.localPosition = balonPos;
                    inHands = false;
                }
                if (!inHands2 && hit.transform.name == "Balon Joje")
                {
                    joje.transform.SetParent(hand.transform);
                    joje.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    joje.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                    inHands2 = true;
                }
                else if (inHands2)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    joje.transform.SetParent(null);
                    joje.transform.localPosition = jojePos;
                    inHands2 = false;
                }
                if (!inHands3 && hit.transform.name == "Erlenmayer")
                {
                    mayer.transform.SetParent(hand.transform);
                    mayer.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    mayer.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands3 = true;
                }
                else if (inHands3)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    mayer.transform.SetParent(null);
                    mayer.transform.localPosition = mayerPos;
                    inHands3 = false;
                }
                if (!inHands4 && hit.transform.name == "Pipet")
                {
                    pipet.transform.SetParent(hand.transform);
                    pipet.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    pipet.transform.localRotation = Quaternion.Euler(-90, 90, 0);
                    inHands4 = true;
                }
                else if (inHands4)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    pipet.transform.SetParent(null);
                    pipet.transform.localPosition = pipetPos;
                    inHands4 = false;
                }
                if (!inHands5 && hit.transform.name == "Deney Tüpü")
                {
                    tüp.transform.SetParent(hand.transform);
                    tüp.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    tüp.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands5 = true;
                }
                else if (inHands5)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    tüp.transform.SetParent(null);
                    tüp.transform.localPosition = tüpPos;
                    inHands5 = false;
                }
                if (!inHands6 && hit.transform.name == "Beherglas")
                {
                    beher.transform.SetParent(hand.transform);
                    beher.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    beher.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands6 = true;
                }
                else if (inHands6)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    beher.transform.SetParent(null);
                    beher.transform.localPosition = beherPos;
                    inHands6 = false;
                }
                if (!inHands7 && hit.transform.name == "Mezür")
                {
                    mezür.transform.SetParent(hand.transform);
                    mezür.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    mezür.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands7 = true;
                }
                else if (inHands7)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    mezür.transform.SetParent(null);
                    mezür.transform.localPosition = mezürPos;
                    inHands7 = false;
                }
                if (!inHands8 && hit.transform.name == "Bohr")
                {
                    bohr.transform.SetParent(hand.transform);
                    bohr.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    bohr.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands8 = true;
                    bohrimg.SetActive(true);
                }
                else if (inHands8)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    bohr.transform.SetParent(null);
                    bohr.transform.localPosition = bohrPos;
                    bohr.transform.localRotation = Quaternion.Euler(-90, 180, 0);
                    inHands8 = false;
                    bohrimg.SetActive(false);
                }
                if (!inHands9 && hit.transform.name == "Thomson")
                {
                    thomson.transform.SetParent(hand.transform);
                    thomson.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    thomson.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands9 = true;
                    thomsonimg.SetActive(true);
                }
                else if (inHands9)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    thomson.transform.SetParent(null);
                    thomson.transform.localPosition = thompsonPos;
                    thomson.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands9 = false;
                    thomsonimg.SetActive(false);
                }
                if (!inHands10 && hit.transform.name == "Rutherford")
                {
                    rutherford.transform.SetParent(hand.transform);
                    rutherford.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    rutherford.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands10 = true;
                    rutherfordimg.SetActive(true);
                }
                else if (inHands10)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    rutherford.transform.SetParent(null);
                    rutherford.transform.localPosition = rutherfordPos;
                    rutherford.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands10 = false;
                    rutherfordimg.SetActive(false);
                }
                if (hit.transform.name == "eldiven")
                {
                    el1.GetComponent<MeshRenderer>().material = EldivenMat;
                    el2.GetComponent<MeshRenderer>().material = EldivenMat;
                    Destroy(EldivenObj);
                    eldiven = true;
                }
                if (!inHands11 && hit.transform.name == "acildurum")
                {
                    acildurum.transform.SetParent(hand.transform);
                    acildurum.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    acildurum.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    inHands11 = true;
                }
                else if (inHands11)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    acildurum.transform.SetParent(null);
                    acildurum.transform.localPosition = acildurumPos;
                    acildurum.transform.localRotation = Quaternion.Euler(270, 270, 0);
                    inHands11 = false;
                }
                if (!inHands12 && hit.transform.name == "Dalton")
                {
                    dalton.transform.SetParent(hand.transform);
                    dalton.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    dalton.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands12 = true;
                    daltonimg.SetActive(true);
                }
                else if (inHands12)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    dalton.transform.SetParent(null);
                    dalton.transform.localPosition = daltonPos;
                    dalton.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands12 = false;
                    daltonimg.SetActive(false);
                }
                if (!inHands13 && hit.transform.name == "güvenlik")
                {
                    güvenlik.transform.SetParent(hand.transform);
                    güvenlik.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    güvenlik.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    inHands13 = true;
                }
                else if (inHands13)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    güvenlik.transform.SetParent(null);
                    güvenlik.transform.localPosition = güvenlikPos;
                    güvenlik.transform.localRotation = Quaternion.Euler(270, 270, 0);
                    inHands13 = false;
                }
                if (!inHands14 && hit.transform.name == "Aşındırıcı")
                {
                    aşındırıcı.transform.SetParent(SembolTab.transform);
                    aşındırıcı.transform.localPosition = new Vector3(0.36f, 0.24f, 10f);
                    aşındırıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands14 = true;
                }
                else if (inHands14)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    aşındırıcı.transform.SetParent(SembolTab.transform);
                    aşındırıcı.transform.localPosition = new Vector3(0.36f, 0.24f, 1.3f);
                    aşındırıcı.transform.localScale = aşındırıcıSca;
                    inHands14 = false;
                }
                if (!inHands15 && hit.transform.name == "Zararlı")
                {
                    zararlı.transform.SetParent(SembolTab.transform);
                    zararlı.transform.localPosition = new Vector3(0.12f, 0.24f, 10f);
                    zararlı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands15 = true;
                }
                else if (inHands15)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    zararlı.transform.SetParent(SembolTab.transform);
                    zararlı.transform.localPosition = new Vector3(0.12f, 0.24f, 1.3f);
                    zararlı.transform.localScale = zararlıSca;
                    inHands15 = false;
                }
                if (!inHands16 && hit.transform.name == "Patlayıcı")
                {
                    patlayıcı.transform.SetParent(SembolTab.transform);
                    patlayıcı.transform.localPosition = new Vector3(-0.12f, 0.24f, 10f);
                    patlayıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands16 = true;
                }
                else if (inHands16)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    patlayıcı.transform.SetParent(SembolTab.transform);
                    patlayıcı.transform.localPosition = new Vector3(-0.12f, 0.24f, 1.3f);
                    patlayıcı.transform.localScale = patlayıcıSca;
                    inHands16 = false;
                }
                if (!inHands17 && hit.transform.name == "Radyoaktif")
                {
                    radyoaktif.transform.SetParent(SembolTab.transform);
                    radyoaktif.transform.localPosition = new Vector3(-0.12f, 0.24f, 10f);
                    radyoaktif.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands17 = true;
                }
                else if (inHands17)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    radyoaktif.transform.SetParent(SembolTab.transform);
                    radyoaktif.transform.localPosition = new Vector3(-0.12f, 0.24f, 1.3f);
                    radyoaktif.transform.localScale = radyoaktifSca;
                    inHands17 = false;
                }
                if (!inHands18 && hit.transform.name == "Tahris")
                {
                    tahris.transform.SetParent(SembolTab.transform);
                    tahris.transform.localPosition = new Vector3(-0.12f, 0.24f, 10f);
                    tahris.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands18 = true;
                }
                else if (inHands18)
                {
                    this.GetComponent<PlayerGrab>().enabled = false;
                    tahris.transform.SetParent(SembolTab.transform);
                    tahris.transform.localPosition = new Vector3(-0.12f, 0.24f, 1.3f);
                    tahris.transform.localScale = tahrisSca;
                    inHands18 = false;
                }
            }
            if (gözlük && eldiven == true)
            {
                sembol.SetActive(true);
                güvenlik.SetActive(true);
                acildurum.SetActive(true);
            }
        }
    }
}
