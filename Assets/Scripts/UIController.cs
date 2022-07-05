using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UIController : MonoBehaviour
{
    [Inject] private Diamond.Factory _factory;

    public void DiamondGenerate()
    {
        Debug.Log("Circle Generated");

        var diamond = _factory.Create();

        diamond.transform.localPosition =
            new Vector3(Random.Range(-8f, 8f), Random.Range(-5f, 5f), Quaternion.identity.z);
    }
}