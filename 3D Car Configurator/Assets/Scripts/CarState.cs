using UnityEngine;
using System.Collections.Generic;

public class CarState : MonoBehaviour
{
    public static CarState Instance;

    [Header("Body")]
    public List<string> bodyHistory = new List<string>();

    [Header("Wheels")]
    public List<string> wheelHistory = new List<string>();

    [Header("Interior")]
    public List<string> interiorHistory = new List<string>();

    [Header("Windows")]
    public List<string> windowHistory = new List<string>();

    void Awake()
    {
        Instance = this;
    }
}