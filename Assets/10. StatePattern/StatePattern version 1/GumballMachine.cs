using UnityEngine;

namespace StatePattern1
{
    public interface State
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
    }

    public class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state;
        int count = 0;

        public GumballMachine(int numerGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            this.count = numerGumballs;
            if (numerGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }
        public void println()
        {
            Debug.Log("주식회사 왕뽑기" + "\n" +
            "자바로 돌아가는 2024년형 뽑기 기계" + "\n" +
            $"남은 개수 : {count}" + "\n" +
            "동전 투입 대기중");
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Debug.Log("알맹이가 나가는 중 ...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public int getCount()
        {
            return count;
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }

        public State getNoQuarterState()
        {
            return noQuarterState;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }

        public State getSoldState()
        {
            return soldState;
        }

        public State getWinnerState()
        {
            return winnerState;
        }
    }

    public class SoldOutState : MonoBehaviour, State
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.Log("매진 되었습니다. 동전을 넣을 수 없습니다.");
        }
        public void ejectQuarter()
        {
            Debug.Log("동전을 넣지 않으셨습니다. 동전을 회수할 수 없습니다.");
        }
        public void turnCrank()
        {
            Debug.Log("매진 되었습니다. 손잡이를 돌릴 수 없습니다.");
        }
        public void dispense()
        {
            Debug.Log("매진 되었습니다. 알맹이가 나갈 수 없습니다.");
        }
    }

    public class NoQuarterState : MonoBehaviour, State
    {
        GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.Log("동전을 넣으셨습니다.");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }
        public void ejectQuarter()
        {
            Debug.Log("동전이 없어 반환되지 않습니다.");
        }
        public void turnCrank()
        {
            Debug.Log("동전이 없어 손잡이를 돌릴 수 없습니다.");
        }
        public void dispense()
        {
            Debug.Log("알맹이가 나갈 수 없습니다.");
        }
    }

    public class HasQuarterState : MonoBehaviour, State
    {
        GumballMachine gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.Log("동전은 한번만 넣어주세요.");
        }
        public void ejectQuarter()
        {
            Debug.Log("동전이 반환됩니다.");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }
        public void turnCrank()
        {
            Debug.Log("손잡이를 돌렸습니다.");
            int random = Random.Range(0, 10);
            if (random == 0 && gumballMachine.getCount() > 1)
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }
        }
        public void dispense()
        {
            Debug.Log("알맹이가 나갈 수 없습니다.");
        }
    }
    public class SoldState : MonoBehaviour, State
    {
        GumballMachine gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.Log("잠시만 기다려 주세요. 알맹이가 나가고 있습니다.");
        }
        public void ejectQuarter()
        {
            Debug.Log("이미 알맹이를 뽑았습니다. 동전을 반환 받을 수 없습니다.");
        }
        public void turnCrank()
        {
            Debug.Log("손잡이는 한번만 돌려주세요");
        }
        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
                Debug.Log("재고 소진. 영업 종료.");
            }
        }
    }

    public class WinnerState : MonoBehaviour, State
    {
        GumballMachine gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Debug.Log("알맹이가 나가고 있습니다. 기다려 주세요.");
        }
        public void ejectQuarter()
        {
            Debug.Log("이미 동전이 소진되어 반환받을 수 없습니다.");
        }

        public void turnCrank()
        {
            Debug.Log("손잡이는 한번만 돌려주세요.");
        }

        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                Debug.Log("축하드립니다! 알맹이를 하나 더 받으실 수 있습니다.");
                gumballMachine.releaseBall();
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Debug.Log("재고 소진. 영업 종료");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }
    }

}