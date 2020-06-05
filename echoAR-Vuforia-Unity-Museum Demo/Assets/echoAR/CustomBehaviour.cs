/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    string dataURL = "";

    GameObject vaseWithTwelveSunflowersTarget;
    GameObject theKissTarget;
    GameObject starryNightTarget;
    GameObject livingStillLifeTarget;


    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {   
        // Init Vuforia image targets
        vaseWithTwelveSunflowersTarget = GameObject.Find("Vase_with_Twelve_Sunflowers_target");
        theKissTarget = GameObject.Find("the_kiss_target");
        starryNightTarget = GameObject.Find("starry_night_target");
        livingStillLifeTarget = GameObject.Find("living_still_life_target");

        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;

        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<BoxCollider>() == null)
        {
            this.gameObject.AddComponent<BoxCollider>();
        }
        if (gameObject.GetComponent<BoxCollider>().size !=  new Vector3(1/this.gameObject.transform.localScale.x,1,1/this.gameObject.transform.localScale.z))
        {
            BoxCollider bc = gameObject.GetComponent<BoxCollider>();
            bc.size = new Vector3(1 / this.gameObject.transform.localScale.x, 1, 1 / this.gameObject.transform.localScale.z);
        }
        if (this.gameObject.name.Equals("sun info text.glb") && this.gameObject.transform.parent != vaseWithTwelveSunflowersTarget.transform)
        {
            this.gameObject.transform.parent = vaseWithTwelveSunflowersTarget.transform;
            
            // get url from metadata
            if (entry.getAdditionalData() != null)
            {
                if (entry.getAdditionalData().TryGetValue("url", out dataURL)) { }
            }
        }
        else if (this.gameObject.name.Equals("kiss info text.glb") && this.gameObject.transform.parent != theKissTarget.transform)
        {
            this.gameObject.transform.parent = theKissTarget.transform;
            // get url from metadata
            if (entry.getAdditionalData() != null)
            {
                if (entry.getAdditionalData().TryGetValue("url", out dataURL)) { }
            }
        }
        else if (this.gameObject.name.Equals("starry info text.glb") && this.gameObject.transform.parent != starryNightTarget.transform)
        {
            this.gameObject.transform.parent = starryNightTarget.transform;
            // get url from metadata
            if (entry.getAdditionalData() != null)
            {
                if (entry.getAdditionalData().TryGetValue("url", out dataURL)) { }
            }
        }
        else if (this.gameObject.name.Equals("living info text.glb") && this.gameObject.transform.parent != livingStillLifeTarget.transform)
        {
            this.gameObject.transform.parent = livingStillLifeTarget.transform;
            // get url from metadata
            if (entry.getAdditionalData() != null)
            {
                if (entry.getAdditionalData().TryGetValue("url", out dataURL)) { }
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse down");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit);
                if (hit.transform != null)
                {
                    if (GameObject.ReferenceEquals(hit.transform.gameObject, gameObject))
                    {
                        OpenUrl(dataURL);
                    }
                }
            }
        }


    }

    void OpenUrl(string url)
    {
        if (url != null && url != "")
        {
            Application.OpenURL(url);
        }
    }
}