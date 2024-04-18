using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleGun : GunWeapon
{
    public override void InitSetting(UnityEngine.UI.Text text)
    {
        data.delayTime = 0.5f;
        data.info = "ÇöÀç ¹«±â : µ¹°Ý ¼ÒÃÑ";
        data.soundEffect = "ÅÁ!";
        data.maxBullet = 20;
        data.bullet = Resources.Load<GameObject>("RifleGunBullet");
    }

    public override void Using(Transform tip, Transform player)
    {
        base.Using(tip, player);
        player.transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * 10 * Time.deltaTime;
    }
}
