using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBars : MonoBehaviour
{
	public Slider prodBar;
	public Slider procBar;

	private void Awake()
	{
		prodBar.value = 0f;
		procBar.value = 0f;
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Productive")
		{
			prodBar.value += 0.1f;
		}
		else if (col.tag == "Procrastination")
		{
			procBar.value += 0.1f;
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Productive")
		{
			prodBar.value -= 0.1f;
		}
		else if (col.tag == "Procrastination")
		{
			procBar.value -= 0.1f;
		}
	}
}
