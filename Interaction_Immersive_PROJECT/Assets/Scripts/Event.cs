using UnityEngine;
using Valve.VR.InteractionSystem;

public class Event : MonoBehaviour
{
  //  public GameObject prefab;
    public void OnPress(Hand hand)
    {
        Debug.Log("SteamVR Button pressed!");
        RenderSettings.ambientLight = Color.red;
        //Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void OnCustomButtonPress()
    {
        Debug.Log("We pushed our custom button!");
       // Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}