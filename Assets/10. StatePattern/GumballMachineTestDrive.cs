using UnityEngine;

public class GumballMachineTestDrive : MonoBehaviour
{
    private void Start()
    {
        GumballMachine gumballMachine = new GumballMachine(3);
        gumballMachine.println();
    }
}
