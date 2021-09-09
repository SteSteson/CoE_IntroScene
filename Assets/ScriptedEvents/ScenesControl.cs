using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesControl : MonoBehaviour
{
    public GameObject SceneToDisable;
    public GameObject SceneToEnable;

    public void SwapScenes()
    {
        SceneToDisable.SetActive(false);
        SceneToEnable.SetActive(true);
    }
}
