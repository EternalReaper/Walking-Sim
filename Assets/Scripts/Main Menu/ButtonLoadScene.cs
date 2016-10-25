using UnityEngine;
using System.Collections;

public class ButtonLoadScene : MonoBehaviour
{
    public string _sceneName = string.Empty;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed()
    {
        Application.LoadLevel(_sceneName);
	}
}
