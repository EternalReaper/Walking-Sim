using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PopUpText : MonoBehaviour
{
    [SerializeField]
    private Text TargetText;
    [SerializeField]
    private string ChangeME;
    [SerializeField]
    private bool Activated;
    [SerializeField]
    private float TimeActive;

    void OnTriggerEnter(Collider WhoHitMe)
    {
        if (WhoHitMe.gameObject.CompareTag("Player"))
        {
            Activated = true;
            TargetText.text = ChangeME;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Activated)
        {
            TargetText.gameObject.SetActive(true);
            if (TimeActive > 0f)
            {
                TimeActive -= Time.deltaTime;

            }
            else
            {
                Activated = false;
                TargetText.gameObject.SetActive(false);
            }
        }
    }
}
