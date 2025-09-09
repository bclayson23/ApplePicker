using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    private Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0");
    }
}
