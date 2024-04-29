//https://refactoring.guru/ko/design-patterns/proxy/csharp/example

using UnityEngine;

namespace Ingyeo.DesignPatterns.Proxy.Conceptual
{
    public interface ISubject
    {
        void Request();
    }

    class RealSubject : MonoBehaviour, ISubject
    {
        public void Request()
        {
            Debug.Log("진짜 주제 : 요청 처리");
        }
    }

    class Proxy : ISubject
    {
        private RealSubject realSubject;

        public Proxy(RealSubject realSubject)
        {
            this.realSubject = realSubject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this.realSubject.Request();
                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Debug.Log("프록시 : 실제 요청을 실행하기 전에 액세스를 확인합니다.");

            return true; //? 체크 안하시는데요
        }

        public void LogAccess()
        {
            Debug.Log("프록시 : 요청시간 기록");
        }
    }

    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }

    class Program : MonoBehaviour
    {
        private void Start()
        {
            Client client = new Client();

            Debug.Log("클라이언트 : 진짜 주제로 클라이언트 코드 실행");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Debug.Log("예예예예예예예예예예예이건구분선");

            Debug.Log("클라이언트 : 같은 코드를 프록시로 실행");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}

