using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class test : UIElement
    {
        //public GameObject prefab;

        void Start()
        {

        }

        void Update()
        {

        }



        protected override void Awake()
        {
            base.Awake();
        }

        protected override void OnButtonClick()
        {
            base.OnButtonClick();
            RenderSettings.ambientLight = Color.red;
        }
    }
}