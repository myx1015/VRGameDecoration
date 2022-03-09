using UnityEngine;
using Valve.VR.InteractionSystem;


public class test3 : UIElement
{
    public GameObject prefab;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnHandHoverBegin(Hand hand)
    {
        base.OnHandHoverBegin(hand);
        Debug.Log("Hover Begin");
    }

    protected override void OnHandHoverEnd(Hand hand)
    {
        base.OnHandHoverEnd(hand);
        Debug.Log("Hover End");
    }

    protected override void HandHoverUpdate(Hand hand)
    {
        base.HandHoverUpdate(hand);
        Debug.Log("Hovering");
    }

    protected override void OnButtonClick()
    {
        base.OnButtonClick();

        Debug.Log("Click");
        Instantiate(prefab, new Vector3(0, 1.5f, 0), Quaternion.identity);

    }
}