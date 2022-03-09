using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LightChange : MonoBehaviour
{
    Light lightq;

    // Start is called before the first frame update
    void Start()
    {
        lightq = this.GetComponent<Light>();
        //lightq.color = new Color(Random.Range(50.0f, 255.0f) / 255f, Random.Range(50.0f, 255.0f) / 255f, Random.Range(50.0f, 255.0f) / 255f);

        StartCoroutine(Changeblood());
    }

    // Update is called once per frame
    void Update()
    {

        //lightq.color = new Color(Random.Range(50, 255) / 255f, Random.Range(50, 255) / 255f, Random.Range(50, 255) / 255f);


    }


    IEnumerator Changeblood()
    {
        int i = 1;
        while (i > 0)
        {
            yield return new WaitForSeconds(0.5f);
            lightq.color = new Color(Random.Range(50, 255) / 255f, Random.Range(50, 255) / 255f, Random.Range(50, 255) / 255f);

        }
    }


}
