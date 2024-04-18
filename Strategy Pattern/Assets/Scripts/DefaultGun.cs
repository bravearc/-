using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGun : GunWeapon
{
    // Start is called before the first frame update
    public override void InitSetting(UnityEngine.UI.Text text)
    {
        data.delayTime = 1f;
        data.info = "ÇöÀç ¹«±â : ±âº» ±ÇÃÑ";
        data.soundEffect = "»§¾ß!";
        data.maxBullet = -1;
        data.bullet = Resources.Load<GameObject>("DefaultGunBullet");
    }

    public override void Using(Transform tip, Transform player)
    {
        base.Using(tip, player);
        player.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * 10 * Time.deltaTime;
        
    }
}
