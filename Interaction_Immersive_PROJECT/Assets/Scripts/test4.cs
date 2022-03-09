using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem.Sample
{
    public class test4 : UIElement
    {
        public GameObject prefab;
        //public Material mat;

        void Start()
        {
            //prefab.GetComponent<Renderer>().material.color = Color.blue;
        }

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void OnButtonClick()
        {
            base.OnButtonClick();
            prefab.GetComponent<Renderer>().material.color = Color.blue;


        }
    }
}