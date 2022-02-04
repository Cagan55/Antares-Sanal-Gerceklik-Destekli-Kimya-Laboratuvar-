using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab2 : MonoBehaviour
{
    public GameObject aktinitler;
    public GameObject alkali;
    public GameObject araGeçiş;
    public GameObject ametal;
    public GameObject geçiş;
    public GameObject halojen;
    public GameObject lantanit;
    public GameObject toprakAlkali;
    public GameObject yarıMetal;
    public GameObject soygaz;
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
    public GameObject PeriyodikCol;
    public GameObject LaboratuvarCol;

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
    bool inHands21 = false;
    bool inHands22 = false;
    bool inHands23 = false;
    bool inHands24 = false;
    bool inHands25 = false;
    bool inHands26 = false;
    bool inHands27 = false;
    bool inHands28 = false;
    bool inHands29 = false;
    bool inHands30 = false;
    bool inHands31 = false;

    public bool gözlük = false;
    public bool eldiven = false;

    Vector3 balonPos;
    Vector3 jojePos;
    Vector3 mayerPos;
    Vector3 pipetPos;
    Vector3 tüpPos;
    Vector3 beherPos;
    Vector3 mezürPos;
    Quaternion balonRotPos;
    Quaternion jojeRotPos;
    Quaternion mayerRotPos;
    Quaternion pipetRotPos;
    Quaternion tüpRotPos;
    Quaternion beherRotPos;
    Quaternion mezürRotPos;
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
    Vector3 aktinitPos;
    Vector3 alkMetalPos;

    Vector3 zararlıSca;
    Vector3 tahrisSca;
    Vector3 patlayıcıSca;
    Vector3 radyoaktifSca;
    Vector3 yakıcıSca;
    Vector3 yanıcıSca;
    Vector3 zehirliSca;
    Vector3 aşındırıcıSca;

    public AudioClip işGüvenlik2;
    public AudioClip işGüvenlik3;
    public AudioClip işGüvenlik4;
    public AudioClip asındırıcıSes;
    public AudioClip zararlıSes;
    public AudioClip zehirliSes;
    public AudioClip tahrisSes;
    public AudioClip yanıcıSes;
    public AudioClip yakıcıSes;
    public AudioClip radyoaktifSes;
    public AudioClip patlayıcıSes;
    public AudioClip balonSes;
    public AudioClip jojeSes;
    public AudioClip mayerSes;
    public AudioClip pipetSes;
    public AudioClip tüpSes;
    public AudioClip beherSes;
    public AudioClip mezürSes;
    public AudioClip bohrSes;
    public AudioClip thomsonSes;
    public AudioClip daltonSes;
    public AudioClip rutherfordSes;
    public AudioClip AtomModelAçıklamaSes;
    public AudioClip LabMalzMasa;
    public AudioClip aktinitSes;
    public AudioClip alkaliSes;
    public AudioClip ametalSes;
    public AudioClip araGecişSes;
    public AudioClip geçisMetSes;
    public AudioClip haloSes;
    public AudioClip lantanitSes;
    public AudioClip soygazSes;
    public AudioClip toprakAlkSes;
    public AudioClip yarıMetalSes;
    public AudioClip periyodikSes;

    public float volume;
    AudioSource audio;
    bool alreadyPlayedIsGuvenlik2;
    bool alreadyPlayedIsGuvenlik3;
    bool alreadyPlayedIsGuvenlik4;
    bool alreadyPlayedAsındırıcı;
    bool alreadyPlayedZararlı;
    bool alreadyPlayedZehirli;
    bool alreadyPlayedTahris;
    bool alreadyPlayedYanıcı;
    bool alreadyPlayedYakıcı;
    bool alreadyPlayedRadyoaktif;
    bool alreadyPlayedPatlayıcı;
    bool alreadyPlayedBalon;
    bool alreadyPlayedJoje;
    bool alreadyPlayedMayer;
    bool alreadyPlayedPipet;
    bool alreadyPlayedTüp;
    bool alreadyPlayedThomson;
    bool alreadyPlayedBeher;
    bool alreadyPlayedMezür;
    bool alreadyPlayedBohr;
    bool alreadyPlayedDalton;
    bool alreadyPlayedRutherford;
    bool alreadyPlayedAtomModelAcSes;
    bool alreadyPlayedLabMalzMasa;
    bool alreadyPlayedPeriyodik;
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
        balonRotPos = balon.transform.rotation;
        jojeRotPos = joje.transform.rotation;
        mayerRotPos = mayer.transform.rotation;
        pipetRotPos = pipet.transform.rotation;
        tüpRotPos = tüp.transform.rotation;
        beherRotPos = beher.transform.rotation;
        mezürRotPos = mezür.transform.rotation;
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
        aktinitPos = aktinitler.transform.position;

        zararlıSca = zararlı.transform.localScale;
        tahrisSca = tahris.transform.localScale;
        patlayıcıSca = patlayıcı.transform.localScale;
        radyoaktifSca = radyoaktif.transform.localScale;
        yakıcıSca = yakıcı.transform.localScale;
        yanıcıSca = yanıcı.transform.localScale;
        zehirliSca = zehirli.transform.localScale;
        aşındırıcıSca = aşındırıcı.transform.localScale;

        audio = GetComponent<AudioSource>();
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
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    balon.transform.SetParent(null);
                    balon.transform.localPosition = balonPos;
                    balon.transform.localRotation = balonRotPos;
                    inHands = false;
                }
            }
            if (inHands && !alreadyPlayedBalon)
            {
                audio.PlayOneShot(balonSes, volume);
                alreadyPlayedBalon = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands2 && hit.transform.name == "Balon Joje")
                {
                    joje.transform.SetParent(hand.transform);
                    joje.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    joje.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                    inHands2 = true;
                }
                else if (inHands2)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    joje.transform.SetParent(null);
                    joje.transform.localPosition = jojePos;
                    joje.transform.localRotation = jojeRotPos;
                    inHands2 = false;
                }
            }
            if (inHands2 && !alreadyPlayedJoje)
            {
                audio.PlayOneShot(jojeSes, volume);
                alreadyPlayedJoje = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands3 && hit.transform.name == "Erlenmayer")
                {
                    mayer.transform.SetParent(hand.transform);
                    mayer.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    mayer.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands3 = true;
                }
                else if (inHands3)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    mayer.transform.SetParent(null);
                    mayer.transform.localPosition = mayerPos;
                    mayer.transform.localRotation = mayerRotPos;
                    inHands3 = false;
                }
            }
            if (inHands3 && !alreadyPlayedMayer)
            {
                audio.PlayOneShot(mayerSes, volume);
                alreadyPlayedMayer = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands4 && hit.transform.name == "Pipet")
                {
                    pipet.transform.SetParent(hand.transform);
                    pipet.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    pipet.transform.localRotation = Quaternion.Euler(0, 135, 0);
                    inHands4 = true;
                }
                else if (inHands4)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    pipet.transform.SetParent(null);
                    pipet.transform.localPosition = pipetPos;
                    pipet.transform.localRotation = pipetRotPos;
                    inHands4 = false;
                }
            }
            if (inHands4 && !alreadyPlayedPipet)
            {
                audio.PlayOneShot(pipetSes, volume);
                alreadyPlayedPipet = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands5 && hit.transform.name == "Deney Tüpü")
                {
                    tüp.transform.SetParent(hand.transform);
                    tüp.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    tüp.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands5 = true;
                }
                else if (inHands5)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    tüp.transform.SetParent(null);
                    tüp.transform.localPosition = tüpPos;
                    tüp.transform.localRotation = tüpRotPos;
                    inHands5 = false;
                }
            }
            if (inHands5 && !alreadyPlayedTüp)
            {
                audio.PlayOneShot(tüpSes, volume);
                alreadyPlayedTüp = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands6 && hit.transform.name == "Beherglas")
                {
                    beher.transform.SetParent(hand.transform);
                    beher.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    beher.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands6 = true;
                }
                else if (inHands6)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    beher.transform.SetParent(null);
                    beher.transform.localPosition = beherPos;
                    beher.transform.localRotation = beherRotPos;
                    inHands6 = false;
                }
            }
            if (inHands6 && !alreadyPlayedBeher)
            {
                audio.PlayOneShot(beherSes, volume);
                alreadyPlayedBeher = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands7 && hit.transform.name == "Mezür")
                {
                    mezür.transform.SetParent(hand.transform);
                    mezür.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    mezür.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands7 = true;
                }
                else if (inHands7)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    mezür.transform.SetParent(null);
                    mezür.transform.localPosition = mezürPos;
                    mezür.transform.localRotation = mezürRotPos;
                    inHands7 = false;
                }
            }
            if (inHands7 && !alreadyPlayedMezür)
            {
                audio.PlayOneShot(mezürSes, volume);
                alreadyPlayedMezür = true;
            }
            if (alreadyPlayedBalon && alreadyPlayedBeher && alreadyPlayedJoje && alreadyPlayedMayer && alreadyPlayedMezür && alreadyPlayedPipet && alreadyPlayedTüp && !alreadyPlayedAtomModelAcSes && !audio.isPlaying)
            {
                audio.PlayOneShot(AtomModelAçıklamaSes, volume);
                alreadyPlayedAtomModelAcSes = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
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
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    bohr.transform.SetParent(null);
                    bohr.transform.localPosition = bohrPos;
                    bohr.transform.localRotation = Quaternion.Euler(-90, 180, 0);
                    inHands8 = false;
                    bohrimg.SetActive(false);
                }
            }
            if (inHands8 && !alreadyPlayedBohr)
            {
                audio.PlayOneShot(bohrSes, volume);
                alreadyPlayedBohr = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
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
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    thomson.transform.SetParent(null);
                    thomson.transform.localPosition = thompsonPos;
                    thomson.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands9 = false;
                    thomsonimg.SetActive(false);
                }
            }
            if (inHands9 && !alreadyPlayedThomson)
            {
                audio.PlayOneShot(thomsonSes, volume);
                alreadyPlayedThomson = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
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
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    rutherford.transform.SetParent(null);
                    rutherford.transform.localPosition = rutherfordPos;
                    rutherford.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands10 = false;
                    rutherfordimg.SetActive(false);
                }
            }
            if (inHands10 && !alreadyPlayedRutherford)
            {
                audio.PlayOneShot(rutherfordSes, volume);
                alreadyPlayedRutherford = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.name == "eldiven")
                {
                    el1.GetComponent<MeshRenderer>().material = EldivenMat;
                    el2.GetComponent<MeshRenderer>().material = EldivenMat;
                    Destroy(EldivenObj);
                    eldiven = true;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.name == "gozluk")
                {
                    gozluk.transform.SetParent(hand.transform);
                    gozluk.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    gozluk.transform.localPosition = new Vector3(0.02f, 0.09f, 3.5f);
                    gözlük = true;
                }
            }
            if (gözlük && eldiven == true)
            {
                sembol.SetActive(true);
                güvenlik.SetActive(true);
                acildurum.SetActive(true);
                if (alreadyPlayedIsGuvenlik2 == false)
                {
                    audio.PlayOneShot(işGüvenlik2, volume);
                    alreadyPlayedIsGuvenlik2 = true;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands11 && hit.transform.name == "acildurum")
                {
                    acildurum.transform.SetParent(hand.transform);
                    acildurum.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    acildurum.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    inHands11 = true;
                }
                else if (inHands11)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    acildurum.transform.SetParent(null);
                    acildurum.transform.localPosition = acildurumPos;
                    acildurum.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    inHands11 = false;
                }
            }
            if (inHands11 && !alreadyPlayedIsGuvenlik3)
            {
                audio.PlayOneShot(işGüvenlik3, volume);
                alreadyPlayedIsGuvenlik3 = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
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
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    dalton.transform.SetParent(null);
                    dalton.transform.localPosition = daltonPos;
                    dalton.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands12 = false;
                    daltonimg.SetActive(false);
                }
            }
            if (inHands12 && !alreadyPlayedDalton)
            {
                audio.PlayOneShot(daltonSes, volume);
                alreadyPlayedDalton = true;
            }
            if (alreadyPlayedBohr && alreadyPlayedDalton && alreadyPlayedRutherford && alreadyPlayedThomson && !alreadyPlayedPeriyodik && !audio.isPlaying)
            {
                audio.PlayOneShot(periyodikSes, volume);
                alreadyPlayedPeriyodik = true;
                PeriyodikCol.SetActive(true);
            }
            else if (!alreadyPlayedBohr && !alreadyPlayedDalton && !alreadyPlayedRutherford && !alreadyPlayedThomson)
            {
                PeriyodikCol.SetActive(false);
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && !inHands13 && hit.transform.name == "güvenlik")
                {
                    güvenlik.transform.SetParent(hand.transform);
                    güvenlik.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    güvenlik.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    inHands13 = true;
                }
                else if (inHands13)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    güvenlik.transform.SetParent(null);
                    güvenlik.transform.localPosition = güvenlikPos;
                    güvenlik.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    inHands13 = false;
                }
            }
            if (inHands13 && !alreadyPlayedIsGuvenlik4)
            {
                audio.PlayOneShot(işGüvenlik4, volume);
                alreadyPlayedIsGuvenlik4 = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands14 && hit.transform.name == "Aşındırıcı")
                {
                    aşındırıcı.transform.SetParent(SembolTab.transform);
                    aşındırıcı.transform.localPosition = new Vector3(0.36f, 0.24f, 10f);
                    aşındırıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands14 = true;
                }
                else if (inHands14)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    aşındırıcı.transform.SetParent(SembolTab.transform);
                    aşındırıcı.transform.localPosition = new Vector3(0.36f, 0.24f, 1.3f);
                    aşındırıcı.transform.localScale = aşındırıcıSca;
                    inHands14 = false;
                }
            }
            if (inHands14 && !alreadyPlayedAsındırıcı)
            {
                audio.PlayOneShot(asındırıcıSes, volume);
                alreadyPlayedAsındırıcı = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands15 && hit.transform.name == "Zararlı")
                {
                    zararlı.transform.SetParent(SembolTab.transform);
                    zararlı.transform.localPosition = new Vector3(0.12f, 0.24f, 10f);
                    zararlı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands15 = true;
                }
                else if (inHands15)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    zararlı.transform.SetParent(SembolTab.transform);
                    zararlı.transform.localPosition = new Vector3(0.12f, 0.24f, 1.3f);
                    zararlı.transform.localScale = zararlıSca;
                    inHands15 = false;
                }
            }
            if (inHands15 && !alreadyPlayedZararlı)
            {
                audio.PlayOneShot(zararlıSes, volume);
                alreadyPlayedZararlı = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands16 && hit.transform.name == "Patlayıcı")
                {
                    patlayıcı.transform.SetParent(SembolTab.transform);
                    patlayıcı.transform.localPosition = new Vector3(-0.12f, 0.24f, 10f);
                    patlayıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands16 = true;
                }
                else if (inHands16)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    patlayıcı.transform.SetParent(SembolTab.transform);
                    patlayıcı.transform.localPosition = new Vector3(-0.12f, 0.24f, 1.3f);
                    patlayıcı.transform.localScale = patlayıcıSca;
                    inHands16 = false;
                }
            }
            if (inHands16 && !alreadyPlayedPatlayıcı)
            {
                audio.PlayOneShot(patlayıcıSes, volume);
                alreadyPlayedPatlayıcı = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands17 && hit.transform.name == "Radyoaktif")
                {
                    radyoaktif.transform.SetParent(SembolTab.transform);
                    radyoaktif.transform.localPosition = new Vector3(-0.37f, 0.24f, 10f);
                    radyoaktif.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands17 = true;
                }
                else if (inHands17)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    radyoaktif.transform.SetParent(SembolTab.transform);
                    radyoaktif.transform.localPosition = new Vector3(-0.37f, 0.24f, 1.3f);
                    radyoaktif.transform.localScale = radyoaktifSca;
                    inHands17 = false;
                }
            }
            if (inHands17 && !alreadyPlayedRadyoaktif)
            {
                audio.PlayOneShot(radyoaktifSes, volume);
                alreadyPlayedRadyoaktif = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands18 && hit.transform.name == "Tahris")
                {
                    tahris.transform.SetParent(SembolTab.transform);
                    tahris.transform.localPosition = new Vector3(-0.37f, -0.24f, 10f);
                    tahris.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands18 = true;
                }
                else if (inHands18)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    tahris.transform.SetParent(SembolTab.transform);
                    tahris.transform.localPosition = new Vector3(-0.37f, -0.24f, 1.3f);
                    tahris.transform.localScale = tahrisSca;
                    inHands18 = false;
                }
            }
            if (inHands18 && !alreadyPlayedTahris)
            {
                audio.PlayOneShot(tahrisSes, volume);
                alreadyPlayedTahris = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands19 && hit.transform.name == "Yakıcı")
                {
                    yakıcı.transform.SetParent(SembolTab.transform);
                    yakıcı.transform.localPosition = new Vector3(-0.12f, -0.22f, 10f);
                    yakıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands19 = true;
                }
                else if (inHands19)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    yakıcı.transform.SetParent(SembolTab.transform);
                    yakıcı.transform.localPosition = new Vector3(-0.12f, -0.22f, 1.3f);
                    yakıcı.transform.localScale = yakıcıSca;
                    inHands19 = false;
                }
            }
            if (inHands19 && !alreadyPlayedYakıcı)
            {
                audio.PlayOneShot(yakıcıSes, volume);
                alreadyPlayedYakıcı = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands20 && hit.transform.name == "Yanıcı")
                {
                    yanıcı.transform.SetParent(SembolTab.transform);
                    yanıcı.transform.localPosition = new Vector3(0.12f, -0.22f, 10f);
                    yanıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands20 = true;
                }
                else if (inHands20)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    yanıcı.transform.SetParent(SembolTab.transform);
                    yanıcı.transform.localPosition = new Vector3(0.12f, -0.22f, 1.3f);
                    yanıcı.transform.localScale = yanıcıSca;
                    inHands20 = false;
                }
            }
            if (inHands20 && !alreadyPlayedYanıcı)
            {
                audio.PlayOneShot(yanıcıSes, volume);
                alreadyPlayedYanıcı = true;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands21 && hit.transform.name == "Zehirli")
                {
                    zehirli.transform.SetParent(SembolTab.transform);
                    zehirli.transform.localPosition = new Vector3(0.36f, -0.22f, 10f);
                    zehirli.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands21 = true;
                }
                else if (inHands21)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    zehirli.transform.SetParent(SembolTab.transform);
                    zehirli.transform.localPosition = new Vector3(0.36f, -0.22f, 1.3f);
                    zehirli.transform.localScale = zehirliSca;
                }
            }
            if (inHands21 && !alreadyPlayedZehirli)
            {
                audio.PlayOneShot(zehirliSes, volume);
                alreadyPlayedZehirli = true;
            }
            if (alreadyPlayedAsındırıcı && alreadyPlayedPatlayıcı && alreadyPlayedRadyoaktif && alreadyPlayedTahris && alreadyPlayedYakıcı && alreadyPlayedYanıcı && alreadyPlayedZararlı && alreadyPlayedZehirli && !alreadyPlayedLabMalzMasa && !audio.isPlaying)
            {
                audio.PlayOneShot(LabMalzMasa, volume);
                alreadyPlayedLabMalzMasa = true;
            }

            if (alreadyPlayedLabMalzMasa && alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4)
            {
                LaboratuvarCol.SetActive(true);
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Aktinitler" && !inHands22)
                {
                    audio.PlayOneShot(aktinitSes, volume);
                    aktinitler.transform.localPosition = new Vector3(-3f, -4f, -4);
                    inHands22 = true;
                }
                else if (inHands22)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    aktinitler.transform.localPosition = new Vector3(0f, -4f, -4f);
                    inHands22 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Alkali Metal" && !inHands23)
                {
                    audio.PlayOneShot(alkaliSes, volume);
                    alkali.transform.localPosition = new Vector3(-3f, -1.5f, 10.5f);
                    inHands23 = true;
                }
                else if (inHands23)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    alkali.transform.localPosition = new Vector3(0f, -1.5f, 10.5f);
                    inHands23 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Ara Geçiş Metaller" && !inHands24)
                {
                    audio.PlayOneShot(araGecişSes, volume);
                    araGeçiş.transform.localPosition = new Vector3(-3f, -1.5f, -4.5f);
                    inHands24 = true;
                }
                else if (inHands24)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    araGeçiş.transform.localPosition = new Vector3(0f, -1.5f, -4.5f);
                    inHands24 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Ametal" && !inHands25)
                {
                    audio.PlayOneShot(ametalSes, volume);
                    ametal.transform.localPosition = new Vector3(-3f, 1.5f, -4.5f);
                    inHands25 = true;
                }
                else if (inHands25)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    ametal.transform.localPosition = new Vector3(0f, 1.5f, -4.5f);
                    inHands25 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Geçiş Metaller" && !inHands26)
                {
                    audio.PlayOneShot(geçisMetSes, volume);
                    geçiş.transform.localPosition = new Vector3(-3f, -1.5f, -0.5f);
                    inHands26 = true;
                }
                else if (inHands26)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    geçiş.transform.localPosition = new Vector3(0f, -1.5f, -0.5f);
                    inHands26 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Halojenler" && !inHands27)
                {
                    audio.PlayOneShot(haloSes, volume);
                    halojen.transform.localPosition = new Vector3(-3f, -0.5f, -5.5f);
                    inHands27 = true;
                }
                else if (inHands27)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    halojen.transform.localPosition = new Vector3(0f, -0.5f, -5.5f);
                    inHands27 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Lantanitler" && !inHands28)
                {
                    audio.PlayOneShot(lantanitSes, volume);
                    lantanit.transform.localPosition = new Vector3(-3f, -3f, -4f);
                    inHands28 = true;
                }
                else if (inHands28)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    lantanit.transform.localPosition = new Vector3(0f, -3f, -4f);
                    inHands28 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Soygazlar" && !inHands29)
                {
                    audio.PlayOneShot(soygazSes, volume);
                    soygaz.transform.localPosition = new Vector3(-3f, -0.5f, -6.5f);
                    inHands29 = true;
                }
                else if (inHands29)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    soygaz.transform.localPosition = new Vector3(0f, -0.5f, -6.5f);
                    inHands29 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Toprak Alkali" && !inHands30)
                {
                    audio.PlayOneShot(toprakAlkSes, volume);
                    toprakAlkali.transform.localPosition = new Vector3(-3f, -1.5f, 9.5f);
                    inHands30 = true;
                }
                else if (inHands30)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    toprakAlkali.transform.localPosition = new Vector3(0f, -1.5f, 9.5f);
                    inHands30 = false;
                }
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.tag == "Yarı Metaller" && !inHands31)
                {
                    audio.PlayOneShot(yarıMetalSes, volume);
                    yarıMetal.transform.localPosition = new Vector3(-3f, -0.5f, -4.5f);
                    inHands31 = false;
                }
                else if (inHands31)
                {
                    this.GetComponent<PlayerGrab2>().enabled = false;
                    yarıMetal.transform.localPosition = new Vector3(0f, -0.5f, -4.5f);
                    inHands31 = false;
                }
            }
        }
    }
}