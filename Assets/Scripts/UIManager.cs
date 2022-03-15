using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public SpriteRenderer balanceMeter;
	public SpriteRenderer head;

	public GameObject help;

	public AudioSource win;
	public AudioSource lose;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			StartMenu();
		}
	}

	public void StartEnd()
	{
		StartCoroutine(EndGame());
	}

	IEnumerator EndGame()
	{
		if (balanceMeter.color == Color.green)
		{
			print("win");
			win.Play();
			yield return new WaitForSeconds(2f);
			SceneManager.LoadScene("Win");
		}

		if (balanceMeter.color == Color.red)
		{
			print("lose");
			lose.Play();
			yield return new WaitForSeconds(2f);
			SceneManager.LoadScene("Lose");
		}
	}

	public void LoadLose()
	{
		SceneManager.LoadScene("Lose");
	}

	public void StartMenu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void Level()
	{
		SceneManager.LoadScene("Level");
	}

	public void Help()
	{
		help.SetActive(true);
	}

	public void CloseHelp()
	{
		help.SetActive(false);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
