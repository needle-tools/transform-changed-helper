using System;
using System.Collections;
using System.Collections.Generic;
using Needle.TransformExtensions;
using UnityEngine;
using UnityEngine.TestTools;

[ExecuteInEditMode]
public class Example : MonoBehaviour
{
	private void OnEnable()
	{
		transform.OnHasChanged(this.OnTransformChanged);
	}

	private void OnDisable()
	{
		transform.OnHasChangedUnsubscribe(this.OnTransformChanged);
	}

	private void OnTransformChanged()
	{
		Debug.Log("transform changed", this);
	}
}