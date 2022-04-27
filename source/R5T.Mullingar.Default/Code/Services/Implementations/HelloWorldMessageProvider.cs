using System;using R5T.T0064;


namespace R5T.Mullingar.Default
{[ServiceImplementationMarker]
    public class HelloWorldMessageProvider : IHelloWorldMessageProvider,IServiceImplementation
    {
        public const string HelloWorldMessage = "Hello world!";


        public string GetHelloWorldMessage()
        {
            return HelloWorldMessageProvider.HelloWorldMessage;
        }
    }
}
