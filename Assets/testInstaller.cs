using UnityEngine;
using Zenject;

public class testInstaller : MonoInstaller<testInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<Greeter>().AsSingle().NonLazy();

    }
}

public class Greeter
{
    public Greeter(string message)
    {
        Debug.Log(message);
    }
}