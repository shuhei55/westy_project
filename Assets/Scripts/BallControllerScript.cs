using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerScript : MonoBehaviour
{
    public GameObject[] balls;

    private float[] ball_pos = new float[] {-2.5f, -1.5f,-0.5f,0.5f,1.5f,2.5f};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ButtonPushed(int num) {
        int random = Random.Range(0,3);
        Instantiate(balls[random],  new Vector3(ball_pos[num],2f,-0.75f), Quaternion.identity);
    }
}
