using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMaterial : MonoBehaviour
{

    [SerializeField] private Material detect;
    [SerializeField] private Material safe;

    [SerializeField] private GameObject screen;

    private void Awake() => screen.GetComponent<MeshRenderer>().material = safe;

    private void OnTriggerEnter (Collider other) => screen.GetComponent<MeshRenderer>().material = detect;
    private void OnTriggerExit(Collider other) => screen.GetComponent<MeshRenderer>().material = safe;
}