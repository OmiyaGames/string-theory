using UnityEngine;
using System.Collections;

public class MatchLocalRotation : MonoBehaviour
{
	public Transform matchRotation;
	private Transform thisRotation;

	// Use this for initialization
	void Start ()
	{
		thisRotation = transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		thisRotation.localRotation = matchRotation.localRotation;
	}
}
