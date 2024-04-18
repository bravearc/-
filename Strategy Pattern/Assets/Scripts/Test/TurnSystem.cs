using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public GameObject pTarget1;
    public GameObject pTarget2;
    public GameObject pTarget3;

    private void Start()
    {

    }
    public void OnClick()
    {
        if (GameManagerTest.isPlayerTurn) 
        {
            if (gameObject.name.Equals("Button(0)"))
            {
                Debug.Log("1번 버튼");
                ShootTest(0, pTarget1);
            }
            if (gameObject.name.Equals("Button(1)"))
            {
                Debug.Log("2번 버튼");
                ShootTest(1, pTarget2);
            }
            if (gameObject.name.Equals("Button(2)"))
            {
                Debug.Log("3번 버튼");
                ShootTest(2, pTarget3);
            }
            else
            {
                return;
            }
        }

    }

    void ShootTest(int target, GameObject go)
    {

        switch (target)
        {
            case 0:
                if (!GameManagerTest.ise0) return;
                GameManagerTest.playerTest.PlayerAttack();
                break;
            case 1:
                if (!GameManagerTest.ise1) return;
                GameManagerTest.playerTest.PlayerAttack();
                break;
            case 2:
                if (!GameManagerTest.ise2) return;
                GameManagerTest.playerTest.PlayerAttack();
                break;
        }
    }

}
