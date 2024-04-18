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
    //JsonData player = new JsonData() { nickname = "성현이", level = 1, coin = 200, skill = false };

    JsonData jRifleGun = new JsonData()
    {
        delayTime = 0.5f,
        info = "현재 무기 : 돌격 소총",
        soundEffect = "탕!",
        maxBullet = 20,
        bullet = Resources.Load<GameObject>("RifleGunBullet")
    };
    JsonData jMachineGun = new JsonData()
    {
        delayTime = 0.2f,
        info = "현재 무기 : 기관총",
        soundEffect = "두두두!",
        maxBullet = 40,
        bullet = Resources.Load<GameObject>("MachineGunBullet")
    };
    JsonData jDefaulGun = new JsonData()
    {
        delayTime = 1f,
        info = "현재 무기 : 기본 권총",
        soundEffect = "빵야!",
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
