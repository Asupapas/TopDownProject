using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, ICollectible
{
    public static event Action OnGemCollected;

    public void Collect()
    {
        Destroy(gameObject);
        OnGemCollected?.Invoke();
    }
}
