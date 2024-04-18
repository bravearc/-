using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;


public struct Data
{
    public float delayTime;
    public int maxBullet;
    public string info;
    public string soundEffect;
    public GameObject bullet;
}
public abstract class GunWeapon : MonoBehaviour
{
    public Data data;

    bool shootAble = true;
    float restTime = 0;

    public abstract void InitSetting(UnityEngine.UI.Text text);

    public virtual void Using(Transform tip, Transform player)
    {
        if (Input.GetKey(KeyCode.Space) && shootAble)
        {
            GameObject bull = Instantiate(data.bullet);
            bull.transform.position = tip.position;
            

            //TextMesh effect = Instantiate(sound);
            //effect.transform.position = tip.position + new Vector3(0, 1f, 0);
            //effect.text = data.soundEffect;

            shootAble = false;

            --data.maxBullet;
        }

        if(shootAble == false)
        {
            restTime += Time.deltaTime;
            if (restTime >= data.delayTime)
            {
                shootAble = true;
                restTime = 0f;
            }
        }
    }
}
