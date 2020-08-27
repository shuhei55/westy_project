using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv3TimerScript : MonoBehaviour
{

    float countTime = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = countTime.ToString("F3"); //小数3桁にして表示
    }
}