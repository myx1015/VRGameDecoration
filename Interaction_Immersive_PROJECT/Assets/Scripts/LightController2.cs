using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Valve.VR.InteractionSystem.Sample
{
    public class LightController2 : UIElement
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
                lightq.color = new Color(255,232,190);

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
          
            lightq.color = new Color(255, 232, 190);

        }



    }
}