using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //array配列
        int[] array = { 1, 2, 3, 4, 5 };
        //for文で順に表示
        for(int i=0; i < array.Length; i++)
        { 
        //配列の中身を表示する
            Debug.Log(array[i]);
        }
        //配列の中身を逆順に表示する
        for (int j=array.Length-1; j >= 0; j--)
        {
            //配列の中身を表示する
            Debug.Log(array[j]);
        }
    }
    
    
    // Update is called once per frame
    void Update () {
		
	}
}

public class Boss
{
    int mp = 53;          //魔法
    int power; // 攻撃力

    public void Attack()
    {
        // 攻撃用の関数
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test2 : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        for(int i=0; i<10; i++)
        {
            lastboss.Attack();
        }
        lastboss.Attack();

    }
}