﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {   
        //　要素数5の配列を初期化する
        int[] array = new int[5];

        //　配列の各要素に値を代入する
       array [0] = 30;
       array [1] = 20;
       array [2] = 50;
       array [3] = 10;
       array [4] = 80;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }
       
        //　配列の要素を逆順で表示する
        for (int i = 4; i > -1; i--){
            Debug.Log(array [i]);
            }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
