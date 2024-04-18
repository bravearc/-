using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    float delayTime = 1;
    bool SgootAble = true;
    float restTime = 0f;
    int maxBullet = 0;


    GameObject bullet;
    GameObject soundEffect;
    public Transform tip;
    public Text info;
    public string bulletName;
    public string soundName;

    private void Start()
    {
        bullet = Resources.Load<GameObject>(bulletName);
        soundEffect = Resources.Load<GameObject>(soundName);
    }


}
