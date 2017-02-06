using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetStare : MonoBehaviour, IStareable {

    private float accruedTime;
    public Text myText;

    private float rearmTimer = 4;
    private bool rearmed;

    private Color baseColor = new Color(.788f, .390f, .390f);
    public Color thisColor;

    private bool unloadForest;

    void Start()
    {
        myText = GetComponentInChildren<Text>();
        myText.color = baseColor;
    }

    void Update()
    {
        rearmTimer += Time.deltaTime;
        if (rearmTimer >= 4)
        {
            rearmed = true;
        }
        else
        {
            rearmed = false;
        }
    }
   
    public void StareAt(float fixedTimeInterval)
    {
        if (rearmed)
        {
            accruedTime += fixedTimeInterval;
            thisColor = Color.Lerp(baseColor, Color.white, accruedTime / 3.0f);
            myText.color = thisColor;
            Debug.Log(accruedTime / 3.0f);

            if (accruedTime >= 3)
            {
                accruedTime = 0;
                rearmTimer = 0;
                myText.color = baseColor;
                GameObject.Find("SceneAssetManager").GetComponent<WoodsLoader>().CallLoad();
                unloadForest = !unloadForest;
                if (unloadForest)
                {
                    myText.text = "Unload Forest";
                }
                else
                {
                    myText.text = "Load Forest";
                }
            }
        }
        else
        {
            myText.color = baseColor;
        }
    }
}
