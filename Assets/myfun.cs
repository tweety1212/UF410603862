using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myfun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public Text mytext;
    int count = 0;
    public void myclick() {
        count++;
        mytext.text = "banana:" + count.ToString();

        
    }

    public Text mytext2;
    public Text mytext4;
    int apple = 0;
    public void aclick()
    {
        apple++;
        mytext2.text = "apple:" + apple.ToString();

        if (apple == 3)
        {
            mytext2.text = "放到空推車上";
            mytext4.text = "放置:滑鼠點擊空推車";
        }
    }

    public Text mytext3;
    public void carclick()
    {
        
            if (apple >= 3)
            {
                mytext2.text = "";
                mytext.text = "終於可以上路啦";
                mytext3.text = "Pass";
            }
            if (apple < count)
            {
                mytext2.text = "喜歡的東西該多一些吧?";
                mytext.text = "其他東西太多啦";
                mytext3.text = "Game Over";
            }

            if (apple ==0 && count==0)
            { 
                mytext2.text = "";
                mytext.text = "會餓死在路上吧...";
                mytext3.text = "Game Over";
            }


    }


}
