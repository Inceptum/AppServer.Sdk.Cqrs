using Inceptum.Cqrs;

namespace Inceptum.AppServer.Sdk.Cqrs
{
    public class AppServerAwareRabbitMqConventionEndpointResolver : RabbitMqConventionEndpointResolver
    {
        public AppServerAwareRabbitMqConventionEndpointResolver(string transport, string serializationFormat, InstanceContext instanceContext, string commandsKeyword = null, string eventsKeyword = null)
            : base(transport, serializationFormat, instanceContext.Name.Replace('.', '-') + "." + instanceContext.AppServerName, instanceContext.Environment, commandsKeyword, eventsKeyword)
        {
        }
    }
}
