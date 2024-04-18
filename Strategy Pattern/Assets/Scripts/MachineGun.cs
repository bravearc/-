using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineGun : GunWeapon
{ 
    public override void InitSetting(Text text)
    {
        data.delayTime = 0.2f;
        data.info = "현재 무기 : 기관총";
        data.soundEffect = "두두두!";
        data.maxBullet = 40;
        data.bullet = Resources.Load<GameObject>("MachineGunBullet");
    }
    
    public override void Using(Transform tip,  Transform player)
    {
        base.Using(tip, player);
        player.transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * 10 * Time.deltaTime;
    }
}
