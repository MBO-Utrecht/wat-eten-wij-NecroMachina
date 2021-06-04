using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI Text;
    string[] asianFood = new string[]{"Sushi", "Peking Eend", "Bami"};

    public void OnClick()
    {
        string showFood = asianFood[Random.Range(0, asianFood.Length)];
        SetText(showFood);
    }


    public void SetText(string text)
    {
        Text.text = "We eten op Maandag: " + text;
    }
    
}
