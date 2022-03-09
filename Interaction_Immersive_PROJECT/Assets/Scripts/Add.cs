using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class Add : UIElement
    {
        public GameObject prefab;
 
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
            Instantiate(prefab, new Vector3(0, 5f, 0), Quaternion.identity);
        }
    }
}