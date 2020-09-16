using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    enum Mode
    {
        Drop,
        Swipe,
        Combo,
    };
    public Text _text;
    public float timer = 6f;
    // Start is called before the first frame update
    void Start() {
        _text.text = "5";
    }

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime;
        _text.text = timer.ToString("f0");
    }
}
