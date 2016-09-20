using UnityEngine;
using System.Collections;

public class SoundDetector : MonoBehaviour {
	
	private GameObject m_Player;

	private bool m_Start;	
	private bool m_Started;

	private void Awake()
	{

		m_Player = GameObject.FindGameObjectWithTag ("Player");

		m_Start = false;
		m_Started = false;
	}

	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player" && m_Started == false)
		{
			m_Start = true;
			m_Started = true;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (m_Start == true) 
		{
			//start playing the sound file (will add this when I have worked out how)
		}

	}
}
