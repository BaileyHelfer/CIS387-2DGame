using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    public Image abilityImage;
    public float cooldown;
    bool isCoolDown;
    public KeyCode ability;

    // Start is called before the first frame update
    void Start()
    {
        abilityImage.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ability();
    }
    void Ability()
    {
        if (Input.GetButtonDown("Fire1") && isCoolDown == false)
        {
            isCoolDown = true;
            abilityImage.fillAmount = 1;
        }
        if (isCoolDown)
        {
            abilityImage.fillAmount -= 1/cooldown * Time.deltaTime;

            if (abilityImage.fillAmount <= 0)
            {
                abilityImage.fillAmount = 0;
                isCoolDown = false;
            }
        }
    }
}
