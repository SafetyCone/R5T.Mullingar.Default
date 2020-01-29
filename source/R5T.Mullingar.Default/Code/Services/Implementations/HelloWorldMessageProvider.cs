using System;


namespace R5T.Mullingar.Default
{
    public class HelloWorldMessageProvider : IHelloWorldMessageProvider
    {
        public const string HelloWorldMessage = "Hello world!";


        public string GetHelloWorldMessage()
        {
            return HelloWorldMessageProvider.HelloWorldMessage;
        }
    }
}
