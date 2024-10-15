using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab ;
    [SerializeField] float spawnRate = 2f;
    private Queue<EnemyBehavior> queue = new ();
    private int batchSize = 5;

    private void CreateBatch()
    {
        for(int _=0; _ < batchSize;_++){
            GameObject newItem = Instantiate(enemyPrefab);
            newItem.SetActive(false);
            queue.Enqueue(newItem.GetComponent<EnemyBehavior>());
        }        
    }

    private void Spawn(){
        if(queue.Count == 0){
            CreateBatch();
        }

        EnemyBehavior item = queue.Dequeue();
        // item.Initialize(this, START, speed);
        item.gameObject.SetActive(true);
    }

}
