using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mushroomScript : MonoBehaviour {
    public GameObject _enemyship;//接收需要加载的物体

    public int enemyCount;//定义生成的个数

    public float WaitTime; //定义一个时间，让怪物在游戏开始一段时间后才开始加载

    public float NextTime;//生成下一波怪物的时间间隔

    public Text textlife;
    int countlife = 3;
    public Text textgame;
    public Text textcow;
    int countcow = 0;
    public Text textsheep;
    int countsheep = 0;
    public Text textchicken;
    int countchicken = 0;

    void Start()

    {
        StartCoroutine(spawnWaves());//定义一个协同函数来限制怪物产生的时间
        
    }

    IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(WaitTime); //在游戏开始后会在waittime时间后才开始执行

        while(countlife>0)
        {
            Vector3 shipPosition = new Vector3(Random.Range(10, 44), Random.Range(0, 0), Random.Range(10, 44));//设置生成物体的随机坐标
            Quaternion shipRotation = Quaternion.Euler(Random.Range(-90, -30), Random.Range(0, 0), Random.Range(0, 0));//设置生成物体的随机角度

            Instantiate(_enemyship, shipPosition, shipRotation);//生成物体

            yield return new WaitForSeconds(NextTime);//限制生成时间间隔
        }

    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "mushroom")
        {
            if (countlife>0)
            {
                Destroy(collision.gameObject);
                countlife--;
                textlife.text = "Life:" + countlife.ToString();
            }
            if (countlife == 0)
            {
                textgame.text = "Game Over";
                textlife.text = "哪來的蘑菇啊...";
            }

        }

        if (collision.gameObject.tag == "cow")
        {
            if (countlife > 0)
            {
                Destroy(collision.gameObject);
                countcow++;
                textcow.text = "Cow:" + countcow.ToString();
            }
            if (countcow==1)
            {
              
                textcow.text = "ok!" ;
            }
        }
        if (collision.gameObject.tag == "sheep")
        {
            if (countlife > 0)
            {
                Destroy(collision.gameObject);
                countsheep++;
                textsheep.text = "Sheep:" + countsheep.ToString();
            }
            if (countsheep == 2)
            {
                textsheep.text = "ok!";
            }
        }
        if (collision.gameObject.tag == "Chicken")
        {
            if (countlife > 0)
            {
                Destroy(collision.gameObject);
                countchicken++;
                textchicken.text = "Chicken:" + countchicken.ToString();
            }
            if (countchicken == 3)
            {
                textchicken.text = "ok!";
            }
        }
        if (countcow == 1 && countsheep == 2 && countchicken == 3)
        {
            textgame.text = "Pass";
            textlife.text = "終於能問到路了...";
        }
    }
    
}
