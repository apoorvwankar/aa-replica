using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public static int PinCount;

	public Text text;
	public Text HStext;

	void Start()
	{
		HStext.text = "HIGH SCORE: " + PlayerPrefs.GetInt("highscore");
		PinCount = 0;
	}

	void Update()
	{
		text.text = PinCount.ToString();
		if (PinCount > PlayerPrefs.GetInt("highscore"))
		{
			PlayerPrefs.SetInt("highscore", PinCount);
		}
	}
}