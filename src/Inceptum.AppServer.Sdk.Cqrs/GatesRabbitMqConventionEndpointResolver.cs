namespace Inceptum.AppServer.Sdk.Cqrs
{
    public class GatesRabbitMqConventionEndpointResolver : AppServerAwareRabbitMqConventionEndpointResolver
    {
        public GatesRabbitMqConventionEndpointResolver(string transport, string serializationFormat, InstanceContext instanceContext)
            : base(transport, serializationFormat, instanceContext, "requests", "responses")
        {
        }
    }
}