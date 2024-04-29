using UnityEngine;

public class MiniDuckSimulator : MonoBehaviour
{
    private void Start()
    {
        Duck mallard = new MallardDuck();
        mallard.performFly();
        mallard.performQuack();
    }
}
