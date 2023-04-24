using UnityEngine;
using System.Collections;

public class MirrorImage : MonoBehaviour
{
	private SpriteRenderer spriteRenderer;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		InvokeRepeating("Mirror", 0f, 2f); // Запускаем Mirror() каждые 2 секунды
	}

	void Mirror()
	{
		spriteRenderer.flipX = !spriteRenderer.flipX; // Инвертируем значение flipX
	}
}
