using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;


    private void Update()
    {
        scoreText.SetText(GameManager.Instance.score.ToString());
    }

}
