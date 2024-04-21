using UnityEngine;

namespace StatePattern0
{
    public class GumballMachineTestDrive : MonoBehaviour
    {
        private void Start()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.println();

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            gumballMachine.println();

            gumballMachine.ejectQuarter();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.turnCrank();

            gumballMachine.println();

            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.turnCrank();
            gumballMachine.ejectQuarter();

            gumballMachine.println();

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.ejectQuarter();

            gumballMachine.println();

            gumballMachine.insertQuarter();
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