using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] GameObject p_bullet;
    [SerializeField] Transform p_shootPosition;
    [SerializeField] Rigidbody2D p_rigidbody;
    Collider2D col;

    int p_Hp = 3;
    int pcount = 1;

    private Vector3 p_enemyPosition;

    private void Start()
    {
        p_rigidbody = p_bullet.GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (p_Hp <= 0)
        {
            if (gameObject.name == "Player (1)")
                GameManagerTest.p_Member -= 1;
            if (gameObject.name == "Player (2)")
                GameManagerTest.p_Member -= 1;
            if (gameObject.name == "Player (3)")
                GameManagerTest.p_Member -= 1;
            //GameManagerTest.enemyTest.e_playerPosition = GameManagerTest.turnSystem.pl2.transform.position;
            Destroy(gameObject);
        }
    }

    public void PlayerAttack()
    {

        //p_enemyPosition = ga.position;

        Instantiate(p_bullet, p_shootPosition.position, Quaternion.identity);
        GameManagerTest.p_Count += 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            p_Hp -= 1;
        }
    }
}
