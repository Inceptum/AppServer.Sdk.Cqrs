# AppServer.Sdk.Cqrs
Assembly exposes public class with name `AppServerAwareRabbitMqConventionEndpointResolver` which implements `IEndpointResolver` interface to be used with `CqrsFacility`.

```
using Inceptum.AppServer.Sdk.Cqrs;

public class Installer : IWindsorInstaller
{
  public void Install(IWindsorContainer container, IConfigurationStore store)
  {
    // First register App Server aware RabbitMQ endpoint resolver

    container.Register(
      Component.For<IEndpointResolver>()
        .ImplementedBy<AppServerAwareRabbitMqConventionEndpointResolver>()
        .DependsOn(new {
          transport = "main",
          serializationFormat = "protobuf"
        }
      )
    );

    // Then add CqrsFacility and configure Cqrs engine
    container.AddFacility<CqrsFacility>(
      /* ... */
    );
  }
}
```
