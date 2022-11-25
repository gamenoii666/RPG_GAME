using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodController : MonoBehaviour
{
    public Image currentFood;
    public Text txt;//
    public float food = 100;
    private float maxfood = 100;
    public static FoodController instance;
   
    void Start()
    {
        instance = this;
        InvokeRepeating("updateFoodHealth", 1.0f, 2f);
    }

    void Update()
    {
        float radio = food / maxfood; // 
        currentFood.rectTransform.localScale = new Vector3(radio, 1, 1);
        txt.text = (radio * 100) + " % ";
    }
    void updateFoodHealth()
    {
        if (food > 0)
        {
            food -= 1f;
        }
    }

    public void healingFood()
    {
        food += 10;
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
}
