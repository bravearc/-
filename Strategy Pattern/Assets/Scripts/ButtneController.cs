using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtneController : MonoBehaviour
{
    public void OnClick()
    {
        if (gameObject.name.Equals("Button(0)"))
        {
            Debug.Log("DefaultGun");
            DefaultGun sc = Resources.Load<DefaultGun>("DefaultGunBullet");
            GameManager.Instance.gunWeapon = sc;
        }

        if (gameObject.name.Equals("Button(1)"))
        {
            Debug.Log("RifleGun");
            RifleGun sc = Resources.Load<RifleGun>("RifleGunBullet");
            GameManager.Instance.gunWeapon = sc;
        }

        if (gameObject.name.Equals("Button(2)"))
        {
            Debug.Log("MachineGun");
            MachineGun sc = Resources.Load<MachineGun>("MachineGunBullet");
            GameManager.Instance.gunWeapon = sc;
        }
    }
}