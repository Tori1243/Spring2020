using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collison : MonoBehaviour
{

	public UnityEvent CollisionEnterEvent;

	private void OnCollisionEnter(Collision other)
	{
		CollisionEnterEvent.Invoke();
	}

}