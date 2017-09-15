using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteFactory : MonoBehaviour {

    private Object[] m_Objects;

    private int m_index = 0;
	// Use this for initialization
	void Start () {
        GetSprite("Number");
	}

    /// <summary>
    /// 获取资源里的sprite图片
    /// </summary>
    public void GetSprite(string name)
    {
        m_Objects = Resources.LoadAll(name);
        if(m_Objects == null)
        {
            Debug.Log("GetSprite failed...");
        }
        else
        {
            Debug.Log(m_Objects.Length);
        }
    }

    public GameObject CreateSprite(int index)
    {
        GameObject tmpObj = new GameObject("Test");
        Image tmpImg = tmpObj.AddComponent<Image>();
        tmpImg.sprite = m_Objects[index] as Sprite;
        return tmpObj;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject tmpObj = CreateSprite(m_index % 10 + 1);
            m_index++;
            tmpObj.transform.parent = transform;
            tmpObj.transform.position = new Vector3(20 * m_index, 20, 0);
        }
	}
}
