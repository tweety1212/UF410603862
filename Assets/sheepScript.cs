using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepScript : MonoBehaviour {
    public GameObject _enemyship;//接收需要加载的物体

    public int enemyCount;//定义生成的个数

    public float WaitTime; //定义一个时间，让怪物在游戏开始一段时间后才开始加载

    public float NextTime;//生成下一波怪物的时间间隔

    void Start()

    {
        StartCoroutine(spawnWaves());//定义一个协同函数来限制怪物产生的时间
    }

    IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(WaitTime); //在游戏开始后会在waittime时间后才开始执行

        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 shipPosition = new Vector3(Random.Range(10, 44), Random.Range(0, 0), Random.Range(10, 44));//设置生成物体的随机坐标
            Quaternion shipRotation = Quaternion.Euler(Random.Range(0, 0), Random.Range(0, 360), Random.Range(0, 0));//设置生成物体的随机角度

            Instantiate(_enemyship, shipPosition, shipRotation);//生成物体

            yield return new WaitForSeconds(NextTime);//限制生成时间间隔
        }

    }
}
