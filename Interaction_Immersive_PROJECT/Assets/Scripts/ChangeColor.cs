using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject prefabred;
    public GameObject prefabblue;
    public GameObject prefabyellow;
    public GameObject prefabblack;
    public GameObject prefabgreen;
    public GameObject prefabwhite;
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "red"|| coll.gameObject.name == "red Variant")
        {
            Debug.Log("Enter " + coll.gameObject.name);
            prefab.GetComponent<Renderer>().material.color = Color.red;
           
            Instantiate(prefabred, new Vector3(2.243f, 0.012f, 1.673f), Quaternion.identity);
        }
        else if (coll.gameObject.name == "blue" || coll.gameObject.name == "blue Variant")
        {
            Debug.Log("Enter " + coll.gameObject.name);
            prefab.GetComponent<Renderer>().material.color = Color.blue;
          
            Instantiate(prefabblue, new Vector3(2.265f, 0.66f, 1.384f), Quaternion.identity);
        }
        else if (coll.gameObject.name == "black" || coll.gameObject.name == "black Variant")
        {
            Debug.Log("Enter " + coll.gameObject.name);
            prefab.GetComponent<Renderer>().material.color = Color.black;
            //Destroy(prefabblack);
            Instantiate(prefabblack, new Vector3(2.207f, 0.612f, 0.17f), Quaternion.identity);
        }
        else if (coll.gameObject.name == "yellow" || coll.gameObject.name == "yellow Variant")
        {
            Debug.Log("Enter " + coll.gameObject.name);
            prefab.GetComponent<Renderer>().material.color = new Color(245, 215, 24);
            
            Instantiate(prefabyellow, new Vector3(2.207f, 0.612f, 1.085f), Quaternion.identity);
        }
        else if (coll.gameObject.name == "green" || coll.gameObject.name == "green Variant")
        {
            Debug.Log("Enter " + coll.gameObject.name);
            prefab.GetComponent<Renderer>().material.color = new Color(61, 250, 3);
            
            Instantiate(prefabgreen, new Vector3(2.207f, 0.612f, 0.684f), Quaternion.identity);
        }
        else if (coll.gameObject.name == "white" || coll.gameObject.name == "white Variant")
        {
            Debug.Log("Enter " + coll.gameObject.name);
            prefab.GetComponent<Renderer>().material.color = Color.white;
            
            Instantiate(prefabwhite, new Vector3(2.106f, 0.612f, -0.040f), Quaternion.identity);
        }
        

    }

    void OnCollisionExit(Collision coll)
    {
        
        //Debug.Log("Exit " + coll.gameObject.name);
    }

    void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.name != "floor")
            Debug.Log("Stay " + coll.gameObject.name);
    }

}
