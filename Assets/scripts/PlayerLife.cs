using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public static float life;

    public Image lifebar;

    private void Start()
    {
        life = 100;
    }

    void Update()
    {
        life = Mathf.Clamp(life, 0, 100);

        float v = life / 100;
        lifebar.fillAmount = v;
    }
}
