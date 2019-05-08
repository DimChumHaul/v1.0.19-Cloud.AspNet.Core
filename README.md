推特 [@ServiceStack](https://twitter.com/servicestack) 
欢迎加入社区 [Google+ Community](https://plus.google.com/communities/112445368900682590445)
软件更新，请关注 [StackOverflow](http://stackoverflow.com/questions/ask) 可以在
[社区论坛](https://forums.servicestack.net/) 寻找技术支持.

> 容器最新功能 [发布日志](https://servicestack.net/release-notes) 新特性请访问实时需求站点 [servicestack.net/features](https://servicestack.net/features)

## **Cloud.AspNet.Core**, 企业级敏捷Web架构, 一个支持**插件式**接入的微服务容器

ServiceStack is a simple, fast, versatile and highly-productive full-featured [Web](http://razor.servicestack.net) and 
[Web Services](http://docs.servicestack.net/web-services.html) Framework that's 
thoughtfully-architected to [reduce artificial complexity](http://docs.servicestack.net/why-not-odata.html#why-not-complexity) and promote 
[remote services best-practices](http://docs.servicestack.net/advantages-of-message-based-web-services.html) 
with a [message-based design](http://docs.servicestack.net/what-is-a-message-based-web-service.html) 
that allows for maximum re-use that can leverage an integrated 
[Service Gateway](http://docs.servicestack.net/service-gateway.html) 
for the creation of loosely-coupled 
[Modularized Service](http://docs.servicestack.net/modularizing-services.html) Architectures.
ServiceStack Services are consumable via an array of built-in fast data formats (inc. 
[JSON](https://github.com/ServiceStack/ServiceStack.Text), XML, 
[CSV](http://docs.servicestack.net/csv-format.html), 
[JSV](http://docs.servicestack.net/json-jsv-and-xml.html), 
[ProtoBuf](http://docs.servicestack.net/protobuf-format.html), 
[Wire](http://docs.servicestack.net/wire-format.html) and 
[MsgPack](http://docs.servicestack.net/messagepack-format.html)) 
as well as XSD/WSDL for [SOAP endpoints](http://docs.servicestack.net/soap-support.html) and 
[Rabbit MQ](http://docs.servicestack.net/rabbit-mq.html), 
[Redis MQ](http://docs.servicestack.net/messaging-and-redis.html) and
[Amazon SQS](https://github.com/ServiceStack/ServiceStack.Aws#sqsmqserver) MQ hosts. 

Its design and simplicity focus offers an unparalleled suite of productivity features that can be declaratively enabled 
without code, from creating fully queryable Web API's with just a single Typed Request DTO with
[Auto Query](http://docs.servicestack.net/autoquery.html) supporting 
[every major RDBMS](https://github.com/ServiceStack/ServiceStack.OrmLite#8-flavours-of-ormlite-is-on-nuget) 
to the built-in support for
[Auto Batched Requests](http://docs.servicestack.net/auto-batched-requests.html) 
or effortlessly enabling rich [HTTP Caching](http://docs.servicestack.net/http-caching.html) and
[Encrypted Messaging](http://docs.servicestack.net/encrypted-messaging.html) 
for all your existing services via [Plugins](http://docs.servicestack.net/plugins.html).

Your same Services also serve as the Controller in ServiceStack's [Smart Razor Views](http://razor.servicestack.net/)
reducing the effort to serve both 
[Web and Single Page Apps](https://github.com/ServiceStackApps/LiveDemos) as well as 
[Rich Desktop and Mobile Clients](https://github.com/ServiceStackApps/HelloMobile) that are able to deliver instant interactive 
experiences using ServiceStack's real-time [Server Events](http://docs.servicestack.net/server-events.html).

ServiceStack Services also maximize productivity for consumers providing an 
[instant end-to-end typed API without code-gen](http://docs.servicestack.net/csharp-client.html) enabling
the most productive development experience for developing .NET to .NET Web Services.

### [Generate Instant Typed APIs from within all Major IDEs!](http://docs.servicestack.net/add-servicestack-reference.html)

ServiceStack now integrates with all Major IDE's used for creating the best native experiences on the most popular platforms 
to enable a highly productive dev workflow for consuming Web Services, making ServiceStack the ideal back-end choice for powering 
rich, native iPhone and iPad Apps on iOS with Swift, Mobile and Tablet Apps on the Android platform with Java, OSX Desktop Appications 
as well as targetting the most popular .NET PCL platforms including Xamarin.iOS, Xamarin.Android, Windows Store, WPF, WinForms and Silverlight: 

<img src="https://raw.githubusercontent.com/ServiceStack/Assets/master/img/wikis/ide-ss-plugin-logos.png" align="right" />

#### [VS.NET integration with ServiceStackVS](https://visualstudiogallery.msdn.microsoft.com/5bd40817-0986-444d-a77d-482e43a48da7)

Providing instant Native Typed API's for 
[C#](http://docs.servicestack.net/csharp-add-servicestack-reference.html), 
[TypeScript](http://docs.servicestack.net/typescript-add-servicestack-reference.html),
[F#](http://docs.servicestack.net/fsharp-add-servicestack-reference.html) and 
[VB.NET](http://docs.servicestack.net/vbnet-add-servicestack-reference.html) 
directly in Visual Studio for the 
[most popular .NET platforms](https://github.com/ServiceStackApps/HelloMobile) including iOS and Android using 
[Xamarin.iOS](https://github.com/ServiceStackApps/HelloMobile#xamarinios-client) and 
[Xamarin.Android](https://github.com/ServiceStackApps/HelloMobile#xamarinandroid-client) on Windows.

#### [Xamarin Studio integration with ServiceStackXS](http://docs.servicestack.net/csharp-add-servicestack-reference.html#xamarin-studio)

Providing [C# Native Types](http://docs.servicestack.net/csharp-add-servicestack-reference.html) 
support for developing iOS and Android mobile Apps using 
[Xamarin.iOS](https://github.com/ServiceStackApps/HelloMobile#xamarinios-client) and 
[Xamarin.Android](https://github.com/ServiceStackApps/HelloMobile#xamarinandroid-client) with 
[Xamarin Studio](https://www.xamarin.com/studio) on OSX. The **ServiceStackXS** plugin also provides a rich web service 
development experience developing Client applications with 
[Mono Develop on Linux](http://docs.servicestack.net/csharp-add-servicestack-reference.html#xamarin-studio-for-linux)

#### [集成到Xcode (ServiceStackXC插件)](http://docs.servicestack.net/swift-add-servicestack-reference.html)

Providing [an instant Native Typed API in Swift](http://docs.servicestack.net/swift-add-servicestack-reference.html) 
including generic Service Clients enabling a highly-productive workflow and effortless consumption of Web Services from 
native iOS and OSX Applications - directly from within Xcode!

#### [集成到Android Studio (ServiceStackIDEA插件)](http://docs.servicestack.net/java-add-servicestack-reference.html)

Providing [an instant Native Typed API in Java](http://docs.servicestack.net/java-add-servicestack-reference.html) 
and [Kotlin](http://docs.servicestack.net/kotlin-add-servicestack-reference.html)
including idiomatic Java Generic Service Clients supporting Sync and Async Requests by levaraging Android's AsyncTasks to enable the creation of services-rich and responsive native Java or Kotlin Mobile Apps on the Android platform - directly from within Android Studio!

#### [集成到IntelliJ (ServiceStackIDEA插件)](http://docs.servicestack.net/java-add-servicestack-reference.html#install-servicestack-idea-from-the-plugin-repository)

The ServiceStack IDEA plugin is installable directly from IntelliJ's Plugin repository and enables seamless integration with IntelliJ Java Maven projects for genearting a Typed API to quickly and effortlessly consume remote ServiceStack Web Services from pure cross-platform Java or Kotlin Clients.

#### [集成到Eclipse (ServiceStackEclipse插件)](https://github.com/ServiceStack/ServiceStack.Java/tree/master/src/ServiceStackEclipse#eclipse-integration-with-servicestack)

The unmatched productivity offered by [Java Add ServiceStack Reference](http://docs.servicestack.net/java-add-servicestack-reference.html) is also available in the 
[ServiceStackEclipse IDE Plugin](https://github.com/ServiceStack/ServiceStack.Java/tree/master/src/ServiceStackEclipse#eclipse-integration-with-servicestack) that's installable 
from the [Eclipse MarketPlace](https://marketplace.eclipse.org/content/servicestackeclipse) to provide deep integration of Add ServiceStack Reference with Eclipse Java Maven Projects
enabling Java Developers to effortlessly Add and Update the references of their evolving remote ServiceStack Web Services.

#### [servicestack-cli - ServiceStack自带的命令行工具](http://docs.servicestack.net/add-servicestack-reference.html#simple-command-line-utilities-for-servicestack)

In addition to our growing list of supported IDE's, the [servicestack-cli](https://github.com/ServiceStack/servicestack-cli)
cross-platform command-line npm scripts makes it easy for build servers, automated tasks and command-line runners of your 
favorite text editors to easily Add and Update ServiceStack References!

## 基于数据库服务的 RESTFul API服务程序示例

在线Demo [stand-alone integration test](https://github.com/ServiceStack/ServiceStack/blob/master/tests/ServiceStack.WebHost.Endpoints.Tests/CustomerRestExample.cs):

```csharp
// 容器引擎核心类
public class AppHost : AppSelfHostBase
{
    public AppHost() 
        : base("Customer REST Example", typeof(CustomerService).Assembly) {}

    public override void Configure(Container container)
    {
        //Register which RDBMS provider to use
        container.Register<IDbConnectionFactory>(c => 
            new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider));

        using (var db = container.Resolve<IDbConnectionFactory>().Open())
        {
            //Create the Customer POCO table if it doesn't already exist
            db.CreateTableIfNotExists<Customer>();
        }
    }
}

//Web Service DTO's
[Route("/customers", "GET")]
public class GetCustomers : IReturn<GetCustomersResponse> {}

public class GetCustomersResponse
{
    public List<Customer> Results { get; set; } 
}

[Route("/customers/{Id}", "GET")]
public class GetCustomer : IReturn<Customer>
{
    public int Id { get; set; }
}

[Route("/customers", "POST")]
public class CreateCustomer : IReturn<Customer>
{
    public string Name { get; set; }
}

[Route("/customers/{Id}", "PUT")]
public class UpdateCustomer : IReturn<Customer>
{
    public int Id { get; set; }

    public string Name { get; set; }
}

[Route("/customers/{Id}", "DELETE")]
public class DeleteCustomer : IReturnVoid
{
    public int Id { get; set; }
}

// POCO DB Model
public class Customer
{
    [AutoIncrement]
    public int Id { get; set; }

    public string Name { get; set; }
}

//Web Services Implementation
public class CustomerService : Service
{
    public object Get(GetCustomers request)
    {
        return new GetCustomersResponse { Results = Db.Select<Customer>() };
    }

    public object Get(GetCustomer request)
    {
        return Db.SingleById<Customer>(request.Id);
    }

    public object Post(CreateCustomer request)
    {
        var customer = new Customer { Name = request.Name };
        Db.Save(customer);
        return customer;
    }

    public object Put(UpdateCustomer request)
    {
        var customer = Db.SingleById<Customer>(request.Id);
        if (customer == null)
            throw HttpError.NotFound("Customer '{0}' does not exist".Fmt(request.Id));

        customer.Name = request.Name;
        Db.Update(customer);

        return customer;
    }

    public void Delete(DeleteCustomer request)
    {
        Db.DeleteById<Customer>(request.Id);
    }
}

```

### [Calling the above REST Service from any C#/.NET Client](http://docs.servicestack.net/csharp-add-servicestack-reference.html)

> No code-gen required, can re-use above Server DTOs:

```csharp
var client = new JsonServiceClient(BaseUri);

//GET /customers
var all = client.Get(new GetCustomers());                         // Count = 0

//POST /customers
var customer = client.Post(new CreateCustomer { Name = "Foo" });

//GET /customer/1
customer = client.Get(new GetCustomer { Id = customer.Id });      // Name = Foo

//GET /customers
all = client.Get(new GetCustomers());                             // Count = 1

//PUT /customers/1
customer = client.Put(
    new UpdateCustomer { Id = customer.Id, Name = "Bar" });       // Name = Bar

//DELETE /customers/1
client.Delete(new DeleteCustomer { Id = customer.Id });

//GET /customers
all = client.Get(new GetCustomers());                             // Count = 0
```

Same code also works with [Android, iOS, Xamarin.Forms, UWP and WPF clients](https://github.com/ServiceStackApps/HelloMobile).

> [F#](http://docs.servicestack.net/fsharp-add-servicestack-reference.html) and 
[VB.NET](http://docs.servicestack.net/vbnet-add-servicestack-reference.html) can re-use same 
[.NET Service Clients](http://docs.servicestack.net/csharp-client.html) and DTO's

### [Calling from TypeScript](http://docs.servicestack.net/typescript-add-servicestack-reference.html#ideal-typed-message-based-api)

```ts
const client = new JsonServiceClient(baseUrl);
const { results } = await client.get(new GetCustomers());
```

### [Calling from Swift](http://docs.servicestack.net/swift-add-servicestack-reference.html#jsonserviceclientswift)

```swift
let client = JsonServiceClient(baseUrl: BaseUri)

client.getAsync(GetCustomers())
    .then {
        let results = $0.results;
    }
```

### [Calling from Java](http://docs.servicestack.net/java-add-servicestack-reference.html#jsonserviceclient-usage)

```java
JsonServiceClient client = new JsonServiceClient(BaseUri);

GetCustomersResponse response = client.get(new GetCustomers());
List<Customer> results = response.results; 
```

### [Calling from Kotlin](http://docs.servicestack.net/kotlin-add-servicestack-reference.html#jsonserviceclient-usage)

```kotlin
val client = JsonServiceClient(BaseUri)

val response = client.get(GetCustomers())
val results = response.results
```

### [Calling from Dart](http://docs.servicestack.net/dart-add-servicestack-reference)

```dart
var client = new JsonServiceClient(BaseUri);

var response = await client.get(GetCustomers());
var results = client.results;
```

### [Calling from jQuery using TypeScript Definitions](http://docs.servicestack.net/typescript-add-servicestack-reference.html#typescript-interface-definitions)

```js
$.getJSON($.ss.createUrl("/customers", request), request, (r: GetCustomersResponse) => {
    var results = r.results;
});
```

Using TypeScript Definitions with Angular HTTP Client:

```ts
this.http.get<GetCustomersResponse>(createUrl('/customers', request)).subscribe(r => {
    this.results = r.results;
});
```

### Calling from jQuery

```js
$.getJSON(baseUri + "/customers", function(r) {
	var results = r.results;
});
```

That's all the application code required to create and consume a simple database-enabled REST Web Service!

## Getting Started

 * [Start with the **Getting Started** section](http://docs.servicestack.net/create-your-first-webservice.html)
 * [Example Apps and Demos](https://github.com/ServiceStackApps/LiveDemos)
 * [Community resources](http://docs.servicestack.net/community-resources.html)

### [Release Notes](https://servicestack.net/release-notes)

## Download

If you have [NuGet](http://www.nuget.org/) installed, the easiest way to get started is to: 

### [Install ServiceStack via NuGet](https://servicestack.net/download).

_Latest v4+ on NuGet is a [commercial release](https://servicestack.net/pricing) with [free quotas](https://servicestack.net/download#free-quotas)._

### [Docs and Downloads for older v3 BSD releases](https://github.com/ServiceStackV3/ServiceStackV3)

### [Live Demos](https://github.com/ServiceStackApps/LiveDemos)

**The [Definitive list of Example Projects, Use-Cases, Demos, Starter Templates](https://github.com/ServiceStackApps/LiveDemos)**
    
## Copying

Since September 2013, ServiceStack source code is available under GNU Affero General Public License/FOSS License Exception, see license.txt in the source. 
Alternative commercial licensing is also available, see https://servicestack.net/pricing for details.

## Contributing

Contributors need to approve the [Contributor License Agreement](https://docs.google.com/forms/d/16Op0fmKaqYtxGL4sg7w_g-cXXyCoWjzppgkuqzOeKyk/viewform) before any code will be reviewed, see the [Contributing docs](http://docs.servicestack.net/contributing.html) for more details. All contributions must include tests verifying the desired behavior.

## OSS Libraries used

ServiceStack includes source code of the great libraries below for some of its core functionality. 
Each library is released under its respective licence:

  - [Mono](https://github.com/mono/mono) [(MIT License)](https://github.com/mono/mono/blob/master/LICENSE)
  - [Funq IOC](http://funq.codeplex.com) [(MS-PL License)](https://opensource.org/licenses/MS-PL)
  - [Fluent Validation](https://github.com/JeremySkinner/FluentValidation) [(Apache License 2.0)](https://github.com/JeremySkinner/FluentValidation/blob/master/License.txt)
  - [Mini Profiler](https://github.com/MiniProfiler/dotnet) [(MIT License)](https://github.com/MiniProfiler/dotnet/blob/master/LICENSE.txt)
  - [Dapper](https://github.com/StackExchange/Dapper) [(Apache License 2.0)](http://www.apache.org/licenses/LICENSE-2.0)
  - [TweetStation's OAuth library](https://github.com/migueldeicaza/TweetStation) [(MIT License)](https://github.com/migueldeicaza/TweetStation/blob/master/LICENSE)
  - [MarkdownSharp](https://code.google.com/archive/p/markdownsharp) [(MIT License)](https://opensource.org/licenses/mit-license.php)
  - [MarkdownDeep](https://github.com/toptensoftware/markdowndeep) [(Apache License 2.0)](http://www.toptensoftware.com/markdowndeep/license)
  - [HtmlCompressor](https://code.google.com/archive/p/htmlcompressor) [(Apache License 2.0)](http://www.apache.org/licenses/LICENSE-2.0)
  - [JSMin](https://github.com/douglascrockford/JSMin/blob/master/jsmin.c) [(Apache License 2.0)](http://www.apache.org/licenses/LICENSE-2.0)
  - [RecyclableMemoryStream](https://github.com/Microsoft/Microsoft.IO.RecyclableMemoryStream) [(MIT License)](https://github.com/Microsoft/Microsoft.IO.RecyclableMemoryStream/blob/master/LICENSE)
  - [ASP.NET MVC](https://github.com/aspnet/Mvc) [(Apache License 2.0)](https://github.com/aspnet/Mvc/blob/release/2.2/LICENSE.txt)
  - [CoreFX](https://github.com/dotnet/corefx) [(MIT License)](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)

## 社区

Follow [@ServiceStack](https://twitter.com/ServiceStack) and 
[+ServiceStack](https://plus.google.com/u/0/communities/112445368900682590445) for project updates.

-----

## 核心团队

 - [mythz](https://github.com/mythz) (Demis Bellot)
 - [layoric](https://github.com/layoric) (Darren Reid) / [@layoric](https://twitter.com/layoric)
 - [xplicit](https://github.com/xplicit) (Sergey Zhukov) / [@quantumcalc](https://twitter.com/quantumcalc)
 - [desunit](https://github.com/desunit) (Sergey Bogdanov) / [@desunit](https://twitter.com/desunit)
 - [arxisos](https://github.com/arxisos) (Steffen Müller) / [@arxisos](https://twitter.com/arxisos)

## Github上类似的开源解决方案

Similar Open source .NET projects for developing or accessing web services include:

 * [Nancy Fx](http://nancyfx.org) - A Sinatra-inspired lightweight Web Framework for .NET:
 * [Fubu MVC](https://fubumvc.github.io/) - A "Front Controller" pattern-style MVC framework designed for use in web applications built on ASP.NET:
 * [Rest Sharp](http://restsharp.org) - An open source REST client for .NET
