using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food
{
    public virtual void ShowMe()
    {
        Debug.Log("Food");
    }
}

public class EggFood : Food
{
    public override void ShowMe()
    {
        Debug.Log("EggFood");
    }
}

public class TomatoFood : Food
{
    public override void ShowMe()
    {
        //base.ShowMe();
        Debug.Log("TomatoFood");

    }
}

public class TeacherFactory : MonoBehaviour {

    private Food m_food;
    public string m_foodName;
    // Use this for initialization
    void Start () {
        m_food = CreateFood(m_foodName);
        if(m_food != null)
        {
            m_food.ShowMe();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Food CreateFood(string strFoodName)
    {
        if("egg" == strFoodName.ToLower())
        {
            return new EggFood();
        }
        else if("tomato" == strFoodName.ToLower())
        {
            return new TomatoFood();
        }
        else
        {
            Debug.Log("Don't have this food...");
            return null;
        }     
    }
}
