using Needle.TransformExtensions;
using UnityEngine;

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