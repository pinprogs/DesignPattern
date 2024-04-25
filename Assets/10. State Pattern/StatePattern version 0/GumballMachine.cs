using UnityEngine;

namespace StatePattern0
{
    public class GumballMachine : MonoBehaviour
    {
        int SOLD_OUT = 0;
        int NO_QUARTER = 1;
        int HAS_QUARTER = 2;
        int SOLD = 3;

        int state = 0;
        int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
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
            if (state == SOLD_OUT)
            {
                Debug.Log("품절입니다.");
            }
            else if (state == NO_QUARTER)
            {
                Debug.Log("동전이 들어갔습니다.");
                state = HAS_QUARTER;
            }
            else if (state == HAS_QUARTER)
            {
                Debug.Log("동전은 한개만 넣어도 충분합니다.");
            }
            else if (state == SOLD)
            {
                Debug.Log("잠시 기다려주세요. 알맹이가 나가고 있습니다.");
            }
        }

        public void ejectQuarter()
        {
            if (state == SOLD_OUT)
            {
                Debug.Log("동전을 넣지 않으셨습니다. 동전이 반환되지 않습니다.");
            }
            else if (state == NO_QUARTER)
            {
                Debug.Log("동전을 넣지 않으셨습니다. 동전이 반환되지 않습니다.");
            }
            else if (state == HAS_QUARTER)
            {
                Debug.Log("동전이 반환 됩니다.");
                state = NO_QUARTER;
            }
            else if (state == SOLD)
            {
                Debug.Log("알맹이가 나가고 있습니다. 동전을 반환받을 수 없습니다.");
            }
        }

        public void turnCrank()
        {
            if (state == SOLD_OUT)
            {
                Debug.Log("매진 되었습니다. 죄송합니다.");
            }
            else if (state == NO_QUARTER)
            {
                Debug.Log("현재 투입된 동전이 없어 알맹이를 뽑을 수 없습니다.");
            }
            else if (state == HAS_QUARTER)
            {
                Debug.Log("손잡이를 돌리셨습니다.");
                state = SOLD;
                dispense();
            }
            else if (state == SOLD)
            {
                Debug.Log("이미 손잡이를 돌리셨습니다.");
            }
        }

        public void dispense()
        {
            if (state == SOLD_OUT)
            {
                Debug.Log("매진입니다.-error");
            }
            else if (state == NO_QUARTER)
            {
                Debug.Log("동전을 넣어주세요.-error");
            }
            else if (state == HAS_QUARTER)
            {
                Debug.Log("알맹이가 나갈 수 없습니다.-error");
            }
            else if (state == SOLD)
            {
                Debug.Log("알맹이가 나가고 있습니다.");
                count = count - 1;
                if (count == 0)
                {
                    Debug.Log("알맹이가 매진되었습니다.");
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }
        }
    }
}