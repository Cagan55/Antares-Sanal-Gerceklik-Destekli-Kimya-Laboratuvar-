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
    bool alreadyPlayedAktinit;
    bool alreadyPlayedAlkali;
    bool alreadyPlayedAmetal;
    bool alreadyPlayedAraGeçiş;
    bool alreadyPlayedGeçiş;
    bool alreadyPlayedHalo;
    bool alreadyPlayedLantanit;
    bool alreadyPlayedSoygaz;
    bool alreadyPlayedToprak;
    bool alreadyPlayedYarı;

    private Vector3 currentLocation;
    private Vector3 işGüvenlikLocation = new Vector3(8.7f, 17.5f, 20f);
    private Vector3 labMalzLocation = new Vector3(6f, 17.5f, -11f);
    private Vector3 atomModelLocation = new Vector3(63.7f, 24f, 25.5f);
    private Vector3 PeriyodikLocation = new Vector3(63.7f, 24f, -18.6f);
    public GameObject Camera;
    public float focusTime;
    public float focusTime2;
    public float focusTime3;
    public float focusTime4;
    public float focusTime5;
    public float focusTime6;
    public float focusTime7;
    public float focusTime8;
    public float focusTime9;
    public float focusTime10;
    public float focusTime11;
    public float focusTime12;
    public float focusTime13;
    public float focusTime14;
    public float focusTime15;
    public float focusTime16;
    public float focusTime17;
    public float focusTime18;
    public float focusTime19;
    public float focusTime20;
    public float focusTime21;
    public float focusTime22;
    public float focusTime23;
    public float focusTime24;
    public float focusTime25;
    public float focusTime26;
    public float focusTime27;
    public float focusTime28;
    public float focusTime29;
    public float focusTime30;
    public float focusTime31;
    public float focusTime32;
    public float focusTime33;
    public float focusTime34;
    public float focusTime35;
    public float focusTime36;
    public float focusTime37;
    public float focusTime38;
    public float focusTime39;
    public float focusTime40;

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

        focusTime = 0;
        focusTime2 = 0;
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.transform.name == "isguvenlikpano")
                {
                    focusTime += Time.deltaTime;
                    focusTime2 = 0;
                }
                if (focusTime >= 2.5)
                {
                    transform.position = Vector3.Lerp(transform.position, işGüvenlikLocation, Time.deltaTime);
                }
                if (hit.transform.name == "labmalzemelerpano")
                {
                    focusTime2 += Time.deltaTime;
                    focusTime = 0;
                }
                if (focusTime2 >= 2.5)
                {
                    transform.position = Vector3.Lerp(transform.position, labMalzLocation, Time.deltaTime);
                }
                if (hit.transform.name == "PerTabloPano")
                {
                    focusTime4 += Time.deltaTime;
                    focusTime3 = 0;
                }
                if (focusTime4 >= 2.5)
                {
                    transform.position = Vector3.Lerp(transform.position, PeriyodikLocation, Time.deltaTime);
                }
                if (hit.transform.name == "AtomModelPano")
                {
                    focusTime3 += Time.deltaTime;
                    focusTime2 = 0;
                }
                if (focusTime3 >= 2.5)
                {
                    transform.position = Vector3.Lerp(transform.position, atomModelLocation, Time.deltaTime);
                }
                if (hit.transform.name == "Balon")
                {
                    focusTime5 += Time.deltaTime;
                }
                if (!inHands && focusTime5 >= 2.5f)
                {
                    balon.transform.SetParent(hand.transform);
                    balon.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    balon.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                    inHands = true;
                }
                else if (inHands && alreadyPlayedBalon && !audio.isPlaying)
                {
                    balon.transform.SetParent(null);
                    balon.transform.localPosition = balonPos;
                    balon.transform.localRotation = balonRotPos;
                    inHands = false;
                    focusTime5 = 0;
                }
                if (inHands && !alreadyPlayedBalon)
                {
                    audio.PlayOneShot(balonSes, volume);
                    alreadyPlayedBalon = true;
                }
                if (hit.transform.name == "Balon Joje")
                {
                    focusTime6 += Time.deltaTime;
                }
                if (!inHands2 && focusTime6 >= 2.5f)
                {
                    joje.transform.SetParent(hand.transform);
                    joje.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    joje.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                    inHands2 = true;
                }
                else if (inHands2 && alreadyPlayedJoje && !audio.isPlaying)
                {
                    joje.transform.SetParent(null);
                    joje.transform.localPosition = jojePos;
                    joje.transform.localRotation = jojeRotPos;
                    inHands2 = false;
                    focusTime6 = 0;
                }
                if (inHands2 && !alreadyPlayedJoje)
                {
                    audio.PlayOneShot(jojeSes, volume);
                    alreadyPlayedJoje = true;
                }
                if (hit.transform.name == "Erlenmayer")
                {
                    focusTime7 += Time.deltaTime;
                }
                if (!inHands3 && focusTime7 >= 2.5f)
                {
                    mayer.transform.SetParent(hand.transform);
                    mayer.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    mayer.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands3 = true;
                }
                else if (inHands3 && alreadyPlayedMayer && !audio.isPlaying)
                {
                    mayer.transform.SetParent(null);
                    mayer.transform.localPosition = mayerPos;
                    mayer.transform.localRotation = mayerRotPos;
                    inHands3 = false;
                    focusTime7 = 0;
                }
                if (inHands3 && !alreadyPlayedMayer)
                {
                    audio.PlayOneShot(mayerSes, volume);
                    alreadyPlayedMayer = true;
                }
                if (hit.transform.name == "Pipet")
                {
                    focusTime8 += Time.deltaTime;
                }
                if (!inHands4 && focusTime8 >= 2.5)
                {
                    pipet.transform.SetParent(hand.transform);
                    pipet.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    pipet.transform.localRotation = Quaternion.Euler(0, 135, 0);
                    inHands4 = true;
                }
                else if (inHands4 && alreadyPlayedPipet && !audio.isPlaying)
                {
                    pipet.transform.SetParent(null);
                    pipet.transform.localPosition = pipetPos;
                    pipet.transform.localRotation = pipetRotPos;
                    inHands4 = false;
                    focusTime8 = 0;
                }
                if (inHands4 && !alreadyPlayedPipet)
                {
                    audio.PlayOneShot(pipetSes, volume);
                    alreadyPlayedPipet = true;
                }
                if (hit.transform.name == "Deney Tüpü")
                {
                    focusTime9 += Time.deltaTime;
                }
                if (!inHands5 && focusTime9 >= 2.5)
                {
                    tüp.transform.SetParent(hand.transform);
                    tüp.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    tüp.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands5 = true;
                }
                else if (inHands5 && alreadyPlayedTüp && !audio.isPlaying)
                {
                    tüp.transform.SetParent(null);
                    tüp.transform.localPosition = tüpPos;
                    tüp.transform.localRotation = tüpRotPos;
                    inHands5 = false;
                    focusTime9 = 0;
                }
                if (inHands5 && !alreadyPlayedTüp)
                {
                    audio.PlayOneShot(tüpSes, volume);
                    alreadyPlayedTüp = true;
                }
                if (hit.transform.name == "Beherglas")
                {
                    focusTime10 += Time.deltaTime;
                }
                if (!inHands6 && focusTime10 >= 2.5)
                {
                    beher.transform.SetParent(hand.transform);
                    beher.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    beher.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands6 = true;
                }
                else if (inHands6 && alreadyPlayedBeher && !audio.isPlaying)
                {
                    beher.transform.SetParent(null);
                    beher.transform.localPosition = beherPos;
                    beher.transform.localRotation = beherRotPos;
                    inHands6 = false;
                    focusTime10 = 0;
                }
                if (inHands6 && !alreadyPlayedBeher)
                {
                    audio.PlayOneShot(beherSes, volume);
                    alreadyPlayedBeher = true;
                }
                if (hit.transform.name == "Mezür")
                {
                    focusTime11 += Time.deltaTime;
                }
                if (!inHands7 && focusTime11 >= 2.5)
                {
                    mezür.transform.SetParent(hand.transform);
                    mezür.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    mezür.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands7 = true;
                }
                else if (inHands7 && alreadyPlayedMezür && !audio.isPlaying)
                {
                    mezür.transform.SetParent(null);
                    mezür.transform.localPosition = mezürPos;
                    mezür.transform.localRotation = mezürRotPos;
                    inHands7 = false;
                    focusTime11 = 0;
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
                if (hit.transform.name == "Bohr")
                {
                    focusTime12 += Time.deltaTime;
                }
                if (!inHands8 && focusTime12 >= 2.5)
                {
                    bohr.transform.SetParent(hand.transform);
                    bohr.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    bohr.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    inHands8 = true;
                    bohrimg.SetActive(true);
                }
                else if (inHands8 && alreadyPlayedBohr && !audio.isPlaying)
                {
                    bohr.transform.SetParent(null);
                    bohr.transform.localPosition = bohrPos;
                    bohr.transform.localRotation = Quaternion.Euler(-90, 180, 0);
                    inHands8 = false;
                    bohrimg.SetActive(false);
                    focusTime12 = 0;
                }
                if (inHands8 && !alreadyPlayedBohr)
                {
                    audio.PlayOneShot(bohrSes, volume);
                    alreadyPlayedBohr = true;
                }
                if (hit.transform.name == "Thomson")
                {
                    focusTime13 += Time.deltaTime;
                }
                if (!inHands9 && focusTime13 >= 2.5)
                {
                    thomson.transform.SetParent(hand.transform);
                    thomson.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    thomson.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands9 = true;
                    thomsonimg.SetActive(true);
                }
                else if (inHands9 && alreadyPlayedThomson && !audio.isPlaying)
                {
                    thomson.transform.SetParent(null);
                    thomson.transform.localPosition = thompsonPos;
                    thomson.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands9 = false;
                    thomsonimg.SetActive(false);
                    focusTime13 = 0;
                }
                if (inHands9 && !alreadyPlayedThomson)
                {
                    audio.PlayOneShot(thomsonSes, volume);
                    alreadyPlayedThomson = true;
                }
                if (hit.transform.name == "Rutherford")
                {
                    focusTime14 += Time.deltaTime;
                }
                if (!inHands10 && focusTime14 >= 2.5)
                {
                    rutherford.transform.SetParent(hand.transform);
                    rutherford.transform.localPosition = new Vector3(-0.48f, -5.32f, 13.54f);
                    rutherford.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands10 = true;
                    rutherfordimg.SetActive(true);
                }
                else if (inHands10 && alreadyPlayedRutherford && !audio.isPlaying)
                {
                    rutherford.transform.SetParent(null);
                    rutherford.transform.localPosition = rutherfordPos;
                    rutherford.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands10 = false;
                    rutherfordimg.SetActive(false);
                    focusTime14 = 0;
                }
                if (inHands10 && !alreadyPlayedRutherford)
                {
                    audio.PlayOneShot(rutherfordSes, volume);
                    alreadyPlayedRutherford = true;
                }
                if (hit.transform.name == "eldiven")
                {
                    focusTime15 += Time.deltaTime;
                }
                if (focusTime15 >= 2.5)
                {
                    el1.GetComponent<MeshRenderer>().material = EldivenMat;
                    el2.GetComponent<MeshRenderer>().material = EldivenMat;
                    Destroy(EldivenObj);
                    eldiven = true;
                }
                if (hit.transform.name == "gozluk")
                {
                    focusTime16 += Time.deltaTime;
                }
                if (focusTime16 >= 2.5)
                {
                    gozluk.transform.SetParent(hand.transform);
                    gozluk.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    gozluk.transform.localPosition = new Vector3(0.02f, 0.13f, 1.42f);
                    gözlük = true;
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
                if (hit.transform.name == "acildurum")
                {
                    focusTime17 += Time.deltaTime;
                }
                if (!inHands11 && focusTime17 >= 2.5)
                {
                    acildurum.transform.SetParent(hand.transform);
                    acildurum.transform.localPosition = new Vector3(-0.48f, -5.32f, 8.8f);
                    acildurum.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    inHands11 = true;
                }
                else if (inHands11 && alreadyPlayedIsGuvenlik3 && !audio.isPlaying)
                {
                    acildurum.transform.SetParent(null);
                    acildurum.transform.localPosition = acildurumPos;
                    acildurum.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    inHands11 = false;
                    focusTime17 = 0;
                }
                if (inHands11 && !alreadyPlayedIsGuvenlik3)
                {
                    audio.PlayOneShot(işGüvenlik3, volume);
                    alreadyPlayedIsGuvenlik3 = true;
                }
                if (hit.transform.name == "Dalton")
                {
                    focusTime18 += Time.deltaTime;
                }
                if (!inHands12 && focusTime18 >= 2.5f)
                {
                    dalton.transform.SetParent(hand.transform);
                    dalton.transform.localPosition = new Vector3(0f, -5f, 6.13f);
                    dalton.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands12 = true;
                    daltonimg.SetActive(true);
                }
                else if (inHands12 && alreadyPlayedDalton && !audio.isPlaying)
                {
                    dalton.transform.SetParent(null);
                    dalton.transform.localPosition = daltonPos;
                    dalton.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    inHands12 = false;
                    daltonimg.SetActive(false);
                    focusTime18 = 0;
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
                if (hit.transform.name == "güvenlik")
                {
                    focusTime19 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && !inHands13 && focusTime19 >= 2.5f)
                {
                    güvenlik.transform.SetParent(hand.transform);
                    güvenlik.transform.localPosition = new Vector3(-0.48f, -5.32f, 8.8f);
                    güvenlik.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    inHands13 = true;
                }
                else if (inHands13 && alreadyPlayedIsGuvenlik4 && !audio.isPlaying)
                {
                    güvenlik.transform.SetParent(null);
                    güvenlik.transform.localPosition = güvenlikPos;
                    güvenlik.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    inHands13 = false;
                    focusTime19 = 0;
                }
                if (inHands13 && !alreadyPlayedIsGuvenlik4)
                {
                    audio.PlayOneShot(işGüvenlik4, volume);
                    alreadyPlayedIsGuvenlik4 = true;
                }
                if (hit.transform.name == "Aşındırıcı")
                {
                    focusTime20 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands14 && focusTime20 >= 2.5)
                {
                    aşındırıcı.transform.SetParent(SembolTab.transform);
                    aşındırıcı.transform.localPosition = new Vector3(0.36f, 0.24f, 10f);
                    aşındırıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands14 = true;
                }
                else if (inHands14 && alreadyPlayedAsındırıcı && !audio.isPlaying)
                {
                    aşındırıcı.transform.SetParent(SembolTab.transform);
                    aşındırıcı.transform.localPosition = new Vector3(0.36f, 0.24f, 1.3f);
                    aşındırıcı.transform.localScale = aşındırıcıSca;
                    inHands14 = false;
                    focusTime20 = 0;
                }
                if (inHands14 && !alreadyPlayedAsındırıcı)
                {
                    audio.PlayOneShot(asındırıcıSes, volume);
                    alreadyPlayedAsındırıcı = true;
                }
                if (hit.transform.name == "Zararlı")
                {
                    focusTime21 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands15 && focusTime21 >= 2.5)
                {
                    zararlı.transform.SetParent(SembolTab.transform);
                    zararlı.transform.localPosition = new Vector3(0.12f, 0.24f, 10f);
                    zararlı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands15 = true;
                }
                else if (inHands15 && alreadyPlayedZararlı && !audio.isPlaying)
                {
                    zararlı.transform.SetParent(SembolTab.transform);
                    zararlı.transform.localPosition = new Vector3(0.12f, 0.24f, 1.3f);
                    zararlı.transform.localScale = zararlıSca;
                    inHands15 = false;
                    focusTime21 = 0;
                }
                if (inHands15 && !alreadyPlayedZararlı)
                {
                    audio.PlayOneShot(zararlıSes, volume);
                    alreadyPlayedZararlı = true;
                }
                if (hit.transform.name == "Patlayıcı")
                {
                    focusTime22 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands16 && focusTime22 >= 2.5)
                {
                    patlayıcı.transform.SetParent(SembolTab.transform);
                    patlayıcı.transform.localPosition = new Vector3(-0.12f, 0.24f, 10f);
                    patlayıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands16 = true;
                }
                else if (inHands16 && alreadyPlayedPatlayıcı && !audio.isPlaying)
                {
                    patlayıcı.transform.SetParent(SembolTab.transform);
                    patlayıcı.transform.localPosition = new Vector3(-0.12f, 0.24f, 1.3f);
                    patlayıcı.transform.localScale = patlayıcıSca;
                    inHands16 = false;
                    focusTime22 = 0;
                }
                if (inHands16 && !alreadyPlayedPatlayıcı)
                {
                    audio.PlayOneShot(patlayıcıSes, volume);
                    alreadyPlayedPatlayıcı = true;
                }
                if (hit.transform.name == "Radyoaktif")
                {
                    focusTime23 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands17 && focusTime23 >= 2.5)
                {
                    radyoaktif.transform.SetParent(SembolTab.transform);
                    radyoaktif.transform.localPosition = new Vector3(-0.37f, 0.24f, 10f);
                    radyoaktif.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands17 = true;
                }
                else if (inHands17 && alreadyPlayedRadyoaktif && !audio.isPlaying)
                {
                    radyoaktif.transform.SetParent(SembolTab.transform);
                    radyoaktif.transform.localPosition = new Vector3(-0.37f, 0.24f, 1.3f);
                    radyoaktif.transform.localScale = radyoaktifSca;
                    inHands17 = false;
                    focusTime23 = 0;
                }
                if (inHands17 && !alreadyPlayedRadyoaktif)
                {
                    audio.PlayOneShot(radyoaktifSes, volume);
                    alreadyPlayedRadyoaktif = true;
                }
                if (hit.transform.name == "Tahris")
                {
                    focusTime24 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands18 && focusTime24 >= 2.5)
                {
                    tahris.transform.SetParent(SembolTab.transform);
                    tahris.transform.localPosition = new Vector3(-0.37f, -0.24f, 10f);
                    tahris.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands18 = true;
                }
                else if (inHands18 && alreadyPlayedTahris && !audio.isPlaying)
                {
                    tahris.transform.SetParent(SembolTab.transform);
                    tahris.transform.localPosition = new Vector3(-0.37f, -0.24f, 1.3f);
                    tahris.transform.localScale = tahrisSca;
                    inHands18 = false;
                    focusTime24 = 0;
                }
                if (inHands18 && !alreadyPlayedTahris)
                {
                    audio.PlayOneShot(tahrisSes, volume);
                    alreadyPlayedTahris = true;
                }
                if (hit.transform.name == "Yakıcı")
                {
                    focusTime25 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands19 && focusTime25 >= 2.5)
                {
                    yakıcı.transform.SetParent(SembolTab.transform);
                    yakıcı.transform.localPosition = new Vector3(-0.12f, -0.22f, 10f);
                    yakıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands19 = true;
                }
                else if (inHands19 && alreadyPlayedYakıcı && !audio.isPlaying)
                {
                    yakıcı.transform.SetParent(SembolTab.transform);
                    yakıcı.transform.localPosition = new Vector3(-0.12f, -0.22f, 1.3f);
                    yakıcı.transform.localScale = yakıcıSca;
                    inHands19 = false;
                    focusTime25 = 0;
                }
                if (inHands19 && !alreadyPlayedYakıcı)
                {
                    audio.PlayOneShot(yakıcıSes, volume);
                    alreadyPlayedYakıcı = true;
                }
                if (hit.transform.name == "Yanıcı")
                {
                    focusTime26 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands20 && focusTime26 >= 2.5)
                {
                    yanıcı.transform.SetParent(SembolTab.transform);
                    yanıcı.transform.localPosition = new Vector3(0.12f, -0.22f, 10f);
                    yanıcı.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands20 = true;
                }
                else if (inHands20 && alreadyPlayedYanıcı && !audio.isPlaying)
                {
                    yanıcı.transform.SetParent(SembolTab.transform);
                    yanıcı.transform.localPosition = new Vector3(0.12f, -0.22f, 1.3f);
                    yanıcı.transform.localScale = yanıcıSca;
                    inHands20 = false;
                    focusTime26 = 0;
                }
                if (inHands20 && !alreadyPlayedYanıcı)
                {
                    audio.PlayOneShot(yanıcıSes, volume);
                    alreadyPlayedYanıcı = true;
                }
                if (hit.transform.name == "Zehirli")
                {
                    focusTime27 += Time.deltaTime;
                }
                if (alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4 && !inHands21 && focusTime27 >= 2.5)
                {
                    zehirli.transform.SetParent(SembolTab.transform);
                    zehirli.transform.localPosition = new Vector3(0.36f, -0.22f, 10f);
                    zehirli.transform.localScale = new Vector3(0.42f, 0.82f, 1f);
                    inHands21 = true;
                }
                else if (inHands21 && !audio.isPlaying && alreadyPlayedZehirli)
                {
                    zehirli.transform.SetParent(SembolTab.transform);
                    zehirli.transform.localPosition = new Vector3(0.36f, -0.22f, 1.3f);
                    zehirli.transform.localScale = zehirliSca;
                    focusTime27 = 0;
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
                    sembol.SetActive(true);
                    güvenlik.SetActive(true);
                    acildurum.SetActive(true);
                }
                if (alreadyPlayedLabMalzMasa && alreadyPlayedIsGuvenlik3 && alreadyPlayedIsGuvenlik4)
                {
                    LaboratuvarCol.SetActive(true);
                }
                if (hit.transform.tag == "Aktinitler")
                {
                    focusTime28 += Time.deltaTime;
                }
                if (focusTime28 >= 2.5 && !inHands22)
                {
                    audio.PlayOneShot(aktinitSes, volume);
                    aktinitler.transform.localPosition = new Vector3(-3f, -4f, -4);
                    inHands22 = true;
                    alreadyPlayedAktinit = true;
                }
                else if (inHands22 && !audio.isPlaying && alreadyPlayedAktinit)
                {
                    aktinitler.transform.localPosition = new Vector3(0f, -4f, -4f);
                    inHands22 = false;
                    focusTime28 = 0;
                }
                if (hit.transform.tag == "Alkali Metal")
                {
                    focusTime29 += Time.deltaTime;
                }
                if (focusTime29 >= 2.5 && !inHands23)
                {
                    audio.PlayOneShot(alkaliSes, volume);
                    alkali.transform.localPosition = new Vector3(-3f, -1.5f, 10.5f);
                    inHands23 = true;
                    alreadyPlayedAlkali = true;
                }
                else if (inHands23 && !audio.isPlaying && alreadyPlayedAlkali)
                {
                    alkali.transform.localPosition = new Vector3(0f, -1.5f, 10.5f);
                    inHands23 = false;
                    focusTime29 = 0;
                }
                if (hit.transform.tag == "Ara Geçiş Metaller")
                {
                    focusTime30 += Time.deltaTime;
                }
                if (focusTime30 >= 2.5 && !inHands24)
                {
                    audio.PlayOneShot(araGecişSes, volume);
                    araGeçiş.transform.localPosition = new Vector3(-3f, -1.5f, -4.5f);
                    inHands24 = true;
                    alreadyPlayedAraGeçiş = true;
                }
                else if (inHands24 && alreadyPlayedAraGeçiş && !audio.isPlaying)
                {
                    araGeçiş.transform.localPosition = new Vector3(0f, -1.5f, -4.5f);
                    inHands24 = false;
                    focusTime30 = 0;
                }
                if (hit.transform.tag == "Ametal")
                {
                    focusTime31 += Time.deltaTime;
                }
                if (focusTime31 >= 2.5 && !inHands25)
                {
                    audio.PlayOneShot(ametalSes, volume);
                    ametal.transform.localPosition = new Vector3(-3f, 1.5f, -4.5f);
                    inHands25 = true;
                    alreadyPlayedAmetal = true;
                }
                else if (inHands25 && alreadyPlayedAmetal && !audio.isPlaying)
                {
                    ametal.transform.localPosition = new Vector3(0f, 1.5f, -4.5f);
                    inHands25 = false;
                    focusTime31 = 0;
                }
                    if (hit.transform.tag == "Geçiş Metaller")
                    {
                        focusTime32 += Time.deltaTime;
                    }
                    if (focusTime32 >= 2.5 && !inHands26)
                    {
                        audio.PlayOneShot(geçisMetSes, volume);
                        geçiş.transform.localPosition = new Vector3(-3f, -1.5f, -0.5f);
                        inHands26 = true;
                        alreadyPlayedAraGeçiş = true;
                    }
                    else if (inHands26 && alreadyPlayedAraGeçiş && !audio.isPlaying)
                    {  
                        geçiş.transform.localPosition = new Vector3(0f, -1.5f, -0.5f);
                        inHands26 = false;
                        focusTime32 = 0;
                    }
                    if (hit.transform.tag == "Halojenler")
                    {
                        focusTime33 += Time.deltaTime;
                    }
                    if (focusTime33 >= 2.5 && !inHands27)
                    {
                        audio.PlayOneShot(haloSes, volume);
                        halojen.transform.localPosition = new Vector3(-3f, -0.5f, -5.5f);
                        inHands27 = true;
                        alreadyPlayedHalo = true;
                    }
                    else if (inHands27 && !audio.isPlaying && alreadyPlayedHalo)
                    {  
                        halojen.transform.localPosition = new Vector3(0f, -0.5f, -5.5f);
                        inHands27 = false;
                        focusTime33 = 0;
                    }
                    if (hit.transform.tag == "Lantanitler")
                    {
                        focusTime34 += Time.deltaTime;
                    }
                    if (focusTime34 >= 2.5 && !inHands28)
                    {
                        audio.PlayOneShot(lantanitSes, volume);
                        lantanit.transform.localPosition = new Vector3(-3f, -3f, -4f);
                        inHands28 = true;
                        alreadyPlayedLantanit = true;
                    }
                    else if (inHands28 && alreadyPlayedLantanit && !audio.isPlaying)
                    {     
                        lantanit.transform.localPosition = new Vector3(0f, -3f, -4f);
                        inHands28 = false;
                        focusTime34 = 0;
                    }
                    if (hit.transform.tag == "Soygazlar")
                    {
                        focusTime35 += Time.deltaTime;
                    }
                    if (focusTime35 >= 2.5 && !inHands29)
                    {
                        audio.PlayOneShot(soygazSes, volume);
                        soygaz.transform.localPosition = new Vector3(-3f, -0.5f, -6.5f);
                        inHands29 = true;
                        alreadyPlayedSoygaz = true;
                    }
                    else if (inHands29 && alreadyPlayedSoygaz && !audio.isPlaying)
                    {     
                        soygaz.transform.localPosition = new Vector3(0f, -0.5f, -6.5f);
                        inHands29 = false;
                        focusTime35 = 0;
                    }
                    if (hit.transform.tag == "Toprak Alkali")
                    {
                        focusTime36 += Time.deltaTime;
                    }
                    if (focusTime36 >= 2.5 && !inHands30)
                    {
                        audio.PlayOneShot(toprakAlkSes, volume);
                        toprakAlkali.transform.localPosition = new Vector3(-3f, -1.5f, 9.5f);
                        inHands30 = true;
                        alreadyPlayedToprak = true;
                    }
                    else if (alreadyPlayedToprak && !audio.isPlaying && inHands30)
                    {     
                        toprakAlkali.transform.localPosition = new Vector3(0f, -1.5f, 9.5f);
                        inHands30 = false;
                        focusTime36 = 0;
                    }
                    if (hit.transform.tag == "Yarı Metaller")
                    {
                        focusTime37 += Time.deltaTime;
                    }
                    if (focusTime37 >= 2.5 && !inHands31)
                    {
                        audio.PlayOneShot(yarıMetalSes, volume);
                        yarıMetal.transform.localPosition = new Vector3(-3f, -0.5f, -4.5f);
                        inHands31 = false;
                        alreadyPlayedYarı = true;
                    }
                    else if (inHands31 && !audio.isPlaying && alreadyPlayedYarı)
                    {     
                        yarıMetal.transform.localPosition = new Vector3(0f, -0.5f, -4.5f);
                        inHands31 = false;
                        focusTime37 = 0;
                    }
                }
            }
        }
    }