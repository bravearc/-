using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineGun : GunWeapon
{ 
    public override void InitSetting(Text text)
    {
        data.delayTime = 0.2f;
        data.info = "���� ���� : �����";
        data.soundEffect = "�εε�!";
        data.maxBullet = 40;
        data.bullet = Resources.Load<GameObject>("MachineGunBullet");
    }
    
    public override void Using(Transform tip,  Transform player)
    {
        base.Using(tip, player);
        player.transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * 10 * Time.deltaTime;
    }
}
