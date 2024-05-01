public abstract class Beverage
{
    protected string description = "제목없음";

    public string getDescription()
    {
        return description;
    }

    public abstract double cost();
}

//추상클래스를 상속받는 추상클래스라니
public abstract class CondimentDecorator : Beverage
{
    //부모도 getDescription 가지고 있는데 여기서도 새로 만드네
    //노란줄 어떤 놈 거인지 모호하다 -> new 키워드를 쓰면 됨!
    //오버라이드는 안됨 왜냐면 추상이라서 그러함
    public abstract new string getDescription();
}

//베버리지는 크게 두가지 상속을 한다. 하나는 주메뉴 녀석들, 다른하나는 데코레이터 클래스. 이 두유형은 다르다. 
public class Espresso : Beverage
{
    public Espresso()
    {
        description = "에스프레쏘";
    }

    public override double cost()
    {
        return 3000;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        description = "하우스 블랜드 커피";
    }

    public override double cost()
    {
        return 3500;
    }
}

public class Mocha : CondimentDecorator
{
    Beverage beverage; //오잉 부모녀석을 객체로 만든다

    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;  //생성은 다른데에서 하고 거기서 베버리지의 객체를 다루는군 그러고 이 객체는 베버리지랑 관련되어서 다형성으로 묶일 수 있을 것만 같구만
    }

    public override string getDescription()
    {
        return beverage.getDescription() + "모카"; //이러려고 베버리지가 필요하구만!! 아 베버리지를 감싸는 녀석이라!! 
    }

    public override double cost()
    {
        return 500 + beverage.cost();
    }
}


//그런데 왜 모카는 베버리지의 상속의 상속이려나. 베버리지 객체를 인스턴싱하고 참조하는거야 상관 업잔슴
