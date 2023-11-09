using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayButtons : MonoBehaviour
{
    public void PlusButton()
    {
        GameManager.Instance.AddScore();

    }

    public void MinusButton()
    {
        GameManager.Instance.MinusScore();
    }
}
