using System;
using UnityEngine;
using Zenject;

public class DiamondInstaller : MonoInstaller
{
    [SerializeField] private GameObject _gameObject;

    public override void InstallBindings()
    {
        Container.BindFactory<Diamond, Diamond.Factory>().FromComponentInNewPrefab(_gameObject).AsSingle();
    }
}