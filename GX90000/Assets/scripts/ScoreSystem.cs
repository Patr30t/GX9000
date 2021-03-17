using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;

    // Start is called before the first frame update
    void Start()
    {
     scoreAmount = 0f;
     pointIncreasedPerSecond = 5f;

    }

    // Update is called once per frame
    void Update()
    {
     scoreText.text = (int) scoreAmount + "Score";
     scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
