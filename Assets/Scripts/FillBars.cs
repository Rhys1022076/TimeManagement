using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBars : MonoBehaviour
{
	public Slider workBar;
	public Slider lifeBar;

	public SpriteRenderer balanceMeter;

	private void Awake()
	{
		workBar.value = 0f;
		lifeBar.value = 0f;
	}

	private void Update()
	{
		if (Mathf.Approximately(workBar.value, lifeBar.value))
		{
			balanceMeter.color = Color.green;
		}
		else
		{
			balanceMeter.color = Color.red;
		}

		if (workBar.value >= 1f && lifeBar.value >= 1f)
		{
			FindObjectOfType<UIManager>().LoadLose();
		}
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Work")
		{
			workBar.value += 0.1f;
		}
		else if (col.tag == "Life")
		{
			lifeBar.value += 0.1f;
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Work")
		{
			workBar.value -= 0.1f;
		}
		else if (col.tag == "Life")
		{
			lifeBar.value -= 0.1f;
		}
	}
}
