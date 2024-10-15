using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    private Vector2 startPos;
    private EnemyManager enemyManager;

    internal void Initialize(EnemyManager manager, Vector2 start, float spd)
    {
        enemyManager = manager;
        startPos = start;
        speed = spd;
    }

    void Update()
    {
        transform.Translate(- Vector3.right * Time.deltaTime * speed);
    }

}
