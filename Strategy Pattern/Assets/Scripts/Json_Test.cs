using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal struct JsonData
{
    //public string nickname;
    //public int level;
    //public int coin = 100;
    //public bool skill;

    public float delayTime;
    public string info;
    public string soundEffect;
    public int maxBullet;
    public GameObject bullet;

}

public class Json_Test : MonoBehaviour
{
    //JsonData player = new JsonData() { nickname = "������", level = 1, coin = 200, skill = false };

    JsonData jRifleGun = new JsonData()
    {
        delayTime = 0.5f,
        info = "���� ���� : ���� ����",
        soundEffect = "��!",
        maxBullet = 20,
        bullet = Resources.Load<GameObject>("RifleGunBullet")
    };
    JsonData jMachineGun = new JsonData()
    {
        delayTime = 0.2f,
        info = "���� ���� : �����",
        soundEffect = "�εε�!",
        maxBullet = 40,
        bullet = Resources.Load<GameObject>("MachineGunBullet")
    };
    JsonData jDefaulGun = new JsonData()
    {
        delayTime = 1f,
        info = "���� ���� : �⺻ ����",
        soundEffect = "����!",
        maxBullet = -1,
        bullet = Resources.Load<GameObject>("DefaultGunBullet")
    };


    void Start()
    {
        string rifleGun = JsonUtility.ToJson(jRifleGun);
        string machineGun = JsonUtility.ToJson(jMachineGun);
        string DefaultGun = JsonUtility.ToJson(jDefaulGun);
        
        
    }   

}
