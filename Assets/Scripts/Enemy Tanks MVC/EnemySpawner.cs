using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyView view;
    public EnemyModel model;
    public List<EnemyView> enemyPrefab;
    public Transform[] spawnPoints;

    void Awake()
    {
        model = new EnemyModel();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyController controller = new EnemyController(view, model);
        controller.InstantiateEnemies(enemyPrefab, spawnPoints);
    }
}
