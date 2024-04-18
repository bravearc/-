using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour
{
    static public GameManagerTest instance;
    static public PlayerTest playerTest;
    static public EnemyTest enemyTest;
    static public TurnSystem turnSystem;

    static public int e_Count;
    static public int p_Count;
    
    static public int e_Member = 3;
    static public int p_Member = 4;
    
    static public int ShootCount;

    static public bool isPlayerTurn = true;

    static public bool isEnemyturn;
    static public bool ise0 = true;
    static public bool ise1 = true;
    static public bool ise2 = true;

    static public Stack<GameObject> enemyStack = new Stack<GameObject>();
    static public Stack<GameObject> playerStack = new Stack<GameObject>();

    public GameObject[] p123;
    public GameObject[] e123;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        enemyStack.Push(e123[0]);
        enemyStack.Push(e123[1]);
        enemyStack.Push(e123[2]);
        playerStack.Push(p123[0]);
        playerStack.Push(p123[1]);
        playerStack.Push(p123[2]);
    }

    private void Start()
    {

    }

}
