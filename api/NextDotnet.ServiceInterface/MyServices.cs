using System;
using ServiceStack;
using NextDotnet.ServiceModel;

namespace NextDotnet.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
