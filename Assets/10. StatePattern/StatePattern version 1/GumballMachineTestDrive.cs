using UnityEngine;

namespace StatePattern1
{
    public class GumballMachineTestDrive : MonoBehaviour
    {
        void Start()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.println();

            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            gumballMachine.println();

            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.turnCrank();

            gumballMachine.println();

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            gumballMachine.println();
        }
    }
}