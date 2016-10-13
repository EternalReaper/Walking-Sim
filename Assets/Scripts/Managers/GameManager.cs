using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public Text m_TimerText;
	private float m_gameTime = 1200;

	public float GameTime { get { return m_gameTime; } }
	void Start () {
		m_TimerText.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		m_gameTime -= Time.deltaTime;
		if (m_gameTime < 0)
		{
			m_gameTime = 0;
		}
		int seconds = Mathf.RoundToInt(m_gameTime);
		m_TimerText.text = string.Format("{0:D2}:{1:D2}",
			(seconds / 60), 
			(seconds % 60));
		
	}
}
