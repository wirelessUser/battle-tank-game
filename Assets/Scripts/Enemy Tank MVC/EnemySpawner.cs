using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemySo[] enemyDataSo;

    public Transform[] spawnedLocation;

    public EnemyView[] enemyPrefabs;


    public List<Transform> spawnedPositionList;
    void Start()
    {
        Debug.Log("EnemyController Soawener start Called");
        SpawnEnemyTank();
    }

  
    public void SpawnEnemyTank()
    {
        EnemyModel enemyModel = new EnemyModel();
        int randomEnemy = Random.Range(0, enemyDataSo.Length);

        EnemySo randomEnemyData = enemyDataSo[randomEnemy];

        // EnemyController enemyContr = new EnemyController(enemyPrefabs, enemyModel, GetRandomSpawnPosition(spawnedLocation));
       
            GameObject newTank = Instantiate(enemyPrefabs[randomEnemy].gameObject, GetRandomSpawnPosition(spawnedLocation),Quaternion.identity);
            EnemyController tankController = new EnemyController();
            tankController.Initialize(randomEnemyData);
            newTank.GetComponent<EnemyView>().InitializController(tankController);
        
       
    }



    public Vector3 GetRandomSpawnPosition(Transform[] spawnedLocation)
    {
        int randomPos;

        do
        {
            randomPos = Random.Range(0, spawnedLocation.Length);
        } while (spawnedPositionList.Contains(spawnedLocation[randomPos]));

        spawnedPositionList.Add(spawnedLocation[randomPos]);

        return spawnedLocation[randomPos].position;
    }

    
}
