using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public WeaponController weaponController;
    public GunWeapon gunWeapon;
    public ButtneController buttneController;
    public Json_Test Json_Test;

    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    public void Start()
    {
        gunWeapon = GetComponent<GunWeapon>();
    }

}