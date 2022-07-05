using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Diamond : MonoBehaviour
{
    public class Factory : PlaceholderFactory<Diamond>
    {
    }
}