using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsLoader : MonoBehaviour {

    private bool woodsRendered;
    private bool ready = true;

    public GameObject Trees;
    public GameObject Rocks;
    public GameObject Fog;
    public GameObject Terrain;
    public GameObject Sound;
    public GameObject Mountains;
    public GameObject WoodsLight;

    public GameObject Floor;
    public GameObject Ceiling;
    public GameObject Walls;

    public List<GameObject> woodsSceneStuff = new List<GameObject>();

	// Use this for initialization
	void Start () {
        LoadWoodsAssets();
    }
	
	// Update is called once per frame
	void Update () {

        //if (ready && Input.GetKeyDown(KeyCode.Space))
        //{
        //    ready = false; 

        //    if (!woodsRendered)
        //    {
        //        Invoke("LoadUnloadWoodsPass1", .3f);
        //        Invoke("LoadUnloadWoodsPass2", 1f);
        //        Invoke("LoadUnloadWoodsPass3", 1.5f);

        //        Invoke("LoadUnloadHoloDeckPass1", .5f);
        //        Invoke("LoadUnloadHoloDeckPass2", 1.3f);
        //        Invoke("LoadUnloadHoloDeckPass3", 1.8f);
        //    }
        //    else
        //    {
        //        Invoke("LoadUnloadWoodsPass1", 1.8f);
        //        Invoke("LoadUnloadWoodsPass2", 1.3f);
        //        Invoke("LoadUnloadWoodsPass3", .5f);

        //        Invoke("LoadUnloadHoloDeckPass1", 1.5f);
        //        Invoke("LoadUnloadHoloDeckPass2", 1f);
        //        Invoke("LoadUnloadHoloDeckPass3", .3f);
        //    }

        //    woodsRendered = !woodsRendered;
        //}

	}

    private void LoadWoodsAssets()
    {
        GameObject justMade = (GameObject)Instantiate(Terrain, transform);
        woodsSceneStuff.Add(justMade);

        GameObject justMade1 = (GameObject)Instantiate(Rocks, transform);
        woodsSceneStuff.Add(justMade1);

        GameObject justMade2 = (GameObject)Instantiate(Trees, transform);
        woodsSceneStuff.Add(justMade2);

        GameObject justMade3 = (GameObject)Instantiate(Mountains, transform);
        woodsSceneStuff.Add(justMade3);

        GameObject justMade4 = (GameObject)Instantiate(Sound, transform);
        woodsSceneStuff.Add(justMade4);

        GameObject justMade5 = (GameObject)Instantiate(Fog, transform);
        woodsSceneStuff.Add(justMade5);

        GameObject justMade6 = (GameObject)Instantiate(WoodsLight, transform);
        woodsSceneStuff.Add(justMade6);

        foreach (GameObject sceneObj in woodsSceneStuff)
        {
            sceneObj.SetActive(false);
        }
    }

    private void LoadUnloadWoodsPass1()
    {
        woodsSceneStuff[0].SetActive(woodsRendered);
        woodsSceneStuff[1].SetActive(woodsRendered);
        woodsSceneStuff[6].SetActive(woodsRendered);

    }

    private void LoadUnloadWoodsPass2()
    {
        woodsSceneStuff[2].SetActive(woodsRendered);
        woodsSceneStuff[3].SetActive(woodsRendered);
    }

    private void LoadUnloadWoodsPass3()
    {
        woodsSceneStuff[4].SetActive(woodsRendered);
        woodsSceneStuff[5].SetActive(woodsRendered);
    }

    private void LoadUnloadHoloDeckPass1()
    {
        Floor.SetActive(!woodsRendered);
    }
    private void LoadUnloadHoloDeckPass2()
    {
        Ceiling.SetActive(!woodsRendered);
    }
    private void LoadUnloadHoloDeckPass3()
    {
        Walls.SetActive(!woodsRendered);
        ready = true;
    }

    public void CallLoad()
    {
        if (ready)
        {
            ready = false;

            if (!woodsRendered)
            {
                Invoke("LoadUnloadWoodsPass1", .3f);
                Invoke("LoadUnloadWoodsPass2", 1f);
                Invoke("LoadUnloadWoodsPass3", 1.5f);

                Invoke("LoadUnloadHoloDeckPass1", .5f);
                Invoke("LoadUnloadHoloDeckPass2", 1.3f);
                Invoke("LoadUnloadHoloDeckPass3", 1.8f);
            }
            else
            {
                Invoke("LoadUnloadWoodsPass1", 1.8f);
                Invoke("LoadUnloadWoodsPass2", 1.3f);
                Invoke("LoadUnloadWoodsPass3", .5f);

                Invoke("LoadUnloadHoloDeckPass1", 1.5f);
                Invoke("LoadUnloadHoloDeckPass2", 1f);
                Invoke("LoadUnloadHoloDeckPass3", .3f);
            }

            woodsRendered = !woodsRendered;
        }
    }
}
