using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuessesAllowed;
	string guessTextFormat = "Is your number {0}?";
	
	public Text guessText;
	
	void Start()
	{
		StartGame();
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		maxGuessesAllowed = 10;
		NextGuess();
	}
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}
	
	void NextGuess()
	{
		maxGuessesAllowed -= 1;
		if(maxGuessesAllowed <= 0)
		{
			Application.LoadLevel("Win");
		}
		else
		{
			guess = Random.Range(min, max + 1);
			guessText.text = string.Format(guessTextFormat, guess.ToString());
		}
	}
}