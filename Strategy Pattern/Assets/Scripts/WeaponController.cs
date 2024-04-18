using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    //public GunWeapon myWeapon;
    GunWeapon lastWeapon;
    
    public Transform tip;
    public TextMesh sound;
    public UnityEngine.UI.Text info;
    
    // Start is called before the first frame update
    void Start()
    {
        lastWeapon = GameManager.Instance.gunWeapon;
        GameManager.Instance.gunWeapon.InitSetting(info);
        GameManager.Instance.gunWeapon = GetComponent<DefaultGun>();
        //lastWeapon = GetComponent<DefaultGun>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (lastWeapon != GameManager.Instance.gunWeapon)
        {
            lastWeapon = GameManager.Instance.gunWeapon;
            GameManager.Instance.gunWeapon.InitSetting(info);

        }

        GameManager.Instance.gunWeapon.Using(tip, this.transform);

        if (GameManager.Instance.gunWeapon.data.maxBullet == 0)
        {
            GameManager.Instance.gunWeapon = Resources.Load<DefaultGun>("DefaultGunBullet");
        }

    }
}
