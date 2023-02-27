using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI ui;
    public void Increment()
    {
        GameManager.meow += GameManager.multi;
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.meow >= 50)
        {
            GameManager.multi += 2;
            GameManager.meow -= 50;
        }

        if (num == 2 && GameManager.meow >= 200)
        {
            GameManager.multi += 25;
            GameManager.meow -= 200;
        }

        if(num == 3 && GameManager.meow >= 800)
        {
            GameManager.multi += 100;
            GameManager.meow -= 800;
        }
    }
    void Update()
    {
        ui.text = "Meow: " + GameManager.meow;
    }
}
