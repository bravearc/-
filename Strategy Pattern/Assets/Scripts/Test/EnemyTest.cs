using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyTest : MonoBehaviour
{
    [SerializeField] GameObject e_bullet;
    [SerializeField] Transform e_shootPosition;
    [SerializeField] Rigidbody2D e_rigidbody;
    Collider2D col;
    public GameObject p_position0;
    public GameObject p_position1;
    public GameObject p_position2;

    int e_Hp = 3;

    public Vector3 e_playerPosition;

    private void Start()
    {
        //Transform o = GameManagerTest.turnSystem.pl1;
        e_rigidbody = e_bullet.GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        e_playerPosition = p_position0.transform.position;
    }
    private void Update()
    {
        if (e_Hp <= 0)
        {
            if (gameObject.name == "Enemy (0)")
                GameManagerTest.ise0 = false;
            if (gameObject.name == "Enemy (1)")
                GameManagerTest.ise1 = false;
            if (gameObject.name == "Enemy (2)")
                GameManagerTest.ise2 = false;
            Destroy(gameObject);
        }

        if (GameManagerTest.isEnemyturn == true)
        {
            StartCoroutine(EnemyAttack(GameManagerTest.p_Member));
        }

        if (GameManagerTest.e_Count == 3)
        {
            GameManagerTest.isEnemyturn = false;
            GameManagerTest.e_Count = 0;
        }

        //e_playerPosition = p_position.position;

    }



    IEnumerator EnemyAttack(int target)
    {
        if (target == 1) { yield return null; }
        yield return new WaitForSeconds(1f);

        Instantiate(e_bullet);
        e_rigidbody.MovePosition(e_playerPosition * Time.deltaTime * 5);
        GameManagerTest.e_Count += 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            e_Hp -= 1;
        }
    }
}
