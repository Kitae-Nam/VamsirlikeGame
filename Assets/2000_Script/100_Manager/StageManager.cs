using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;


public class StageManager : MonoBehaviour
{
    public System.Collections.Generic.List<Enemy> EnemyList = new System.Collections.Generic.List<Enemy>();

    private void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        Spawn();
    }
    public void Spawn()
    {
        for (int i = 0; i < 10; i++)
        {
            Enemy newEnemy = Instantiate(Manager.Data.RefEnemy);

            float randomXposotopn = Random.Range(-4f, 4f);
            float randomYposotopn = Random.Range(-4f, 4f);

            newEnemy.transform.position = new Vector3(randomXposotopn, randomYposotopn, 0);

            EnemyList.Add(newEnemy);
        }
    }
}
