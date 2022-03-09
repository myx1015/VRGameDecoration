using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class LightController : UIElement
    {
        Light lightq;
        public GameObject light;

        void Start()
        {
            lightq = light.GetComponent<Light>();
            //StartCoroutine(Changeblood());
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



        protected override void Awake()
        {
            base.Awake();
            //StartCoroutine(Changeblood());
        }

        protected override void OnButtonClick()
        {
            base.OnButtonClick();
            lightq.color = new Color(Random.Range(50, 255) / 255f, Random.Range(50, 255) / 255f, Random.Range(50, 255) / 255f);

            //StartCoroutine(Changeblood());



        }

 

    }
}