using UnityEngine;

public class GumballMachine : MonoBehaviour
{
    int SOLD_OUT = 0;
    int NO_QUARTER = 1;
    int HAS_QUARTER = 2;
    int SOLD = 3;

    int state;
    int count = 0;
    public GumballMachine(int count)
    {
        this.count = count;
        if (count > 0)
        {
            state = NO_QUARTER;
        }
    }


    private void Start()
    {
        state = SOLD_OUT;
    }

    //Actions

    public void insertQuarter()
    {
        if (state == SOLD_OUT)
        {
            Debug.Log("매진 되었습니다 다음 기회에 이용해주세요");
            Debug.Log("매진 되었습니다 다음 기회에 이용해주세요");
        }
        else if (state == NO_QUARTER)
        {
            state = HAS_QUARTER;
            Debug.Log("동전을 넣으셨습니다");
        }
        else if (state == HAS_QUARTER)
        {
            Debug.Log("동전은 한개만 넣어주세요");
        }
        else if (state == SOLD)
        {
            Debug.Log("잠깐만 기다려 주세요 알맹이가 나가고 있습니다");
        }
    }

    public void ejectQuarter()
    {
        if (state == SOLD_OUT)
        {
            Debug.Log("동전을 넣지 않으셨습니다 동전이 반환되지 않습니다");
        }
        else if (state == NO_QUARTER)
        {
            Debug.Log("동전을 넣어주세요");
        }
        else if (state == HAS_QUARTER)
        {
            Debug.Log("동전이 반환됩니다");
            state = NO_QUARTER;
        }
        else if (state == SOLD)
        {
            Debug.Log("이미 알맹이를 뽑으셨습니다");
        }
    }

    public void turnCrank()
    {
        if (state == SOLD_OUT)
        {
            Debug.Log("손잡이는 한번만 돌려주세요");
        }
        else if (state == NO_QUARTER)
        {
            Debug.Log("동전을 넣어주세요");
        }
        else if (state == HAS_QUARTER)
        {
            Debug.Log("손잡이를 돌리셨습니다");
            state = SOLD;
            dispence();
        }
        else if (state == SOLD)
        {
            Debug.Log("손잡이는 한번만 돌려주세욤");
        }
    }

    public void dispence()
    {
        if (state == SOLD_OUT)
        {
            Debug.Log("매진입니다");
        }
        else if (state == NO_QUARTER)
        {
            Debug.Log("동전을 넣어주세요");
        }
        else if (state == HAS_QUARTER)
        {
            Debug.Log("알맹이가 나갈 수 없습니다");
        }
        else if (state == SOLD)
        {
            Debug.Log("알맹이가 나가고 있습니다");
            count = count - 1;
            if (count == 0)
            {
                Debug.Log("더 이상 알맹이가 없습니다");
                state = SOLD_OUT;
            }
            else
            {
                Debug.Log("");
                state = NO_QUARTER;
            }
        }
    }

    public void println()
    {
        Debug.Log("주식회사 왕뽑기" + "\n" +
        "씨샵으로 돌아가는 2004년형 뽑기기계" + "\n" +
        $"남은 개수 : {count}" + "\n" +
        "동전투입 대기중");
    }
}
