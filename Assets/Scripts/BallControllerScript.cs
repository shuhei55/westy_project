using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerScript : MonoBehaviour
{
    public GameObject[] balls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1Pushed() {
        int random = Random.Range(0,3);
        Instantiate(balls[random],  new Vector3(-2.5f,2f,-0.75f), Quaternion.identity);
    }

    public void Button2Pushed() {
        int random = Random.Range(0, 3);
        Instantiate(balls[random], new Vector3(-1.5f, 2f, -0.75f), Quaternion.identity);
    }

    public void Button3Pushed() {
        int random = Random.Range(0, 3);
        Instantiate(balls[random], new Vector3(-0.5f, 2f, -0.75f), Quaternion.identity);
    }

    public void Button4Pushed() {
        int random = Random.Range(0, 3);
        Instantiate(balls[random], new Vector3(0.5f, 2f, -0.75f), Quaternion.identity);
    }

    public void Button5Pushed() { 
        int random = Random.Range(0, 3);
        Instantiate(balls[random], new Vector3(1.5f, 2f, -0.75f), Quaternion.identity);
    }

    public void Button6Pushed(){
        int random = Random.Range(0, 3);
        Instantiate(balls[random], new Vector3(2.5f, 2f, -0.75f), Quaternion.identity);
    }
}
