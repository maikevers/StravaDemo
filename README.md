<h1 align="center">
  Demo of a ASP .NET Core 3.1 Api with domain model.
</h1>
<hr/>

<div align="center">

<h3 align="center">
  <a href="https://docs.automapper.org/en/stable/Getting-started.html">Automapper Docs</a>
  <span> · </span>
  <a href="http://restsharp.org/">RestSharp Docs</a>
  <span> · </span>
  <a href="https://martinfowler.com/tags/domain%20driven%20design.html">DDD Docs</a>
</h3>

This is a small demo of a .NET Core 3.1 API using RestSharp which gets its from the Strava API. This demo is setup using a domain driven approach to compute some values regarding the average speed of recent sports activities. This is mainly a showcase of how to setup and decouple your domain model. A database is ommitted for sake of simplicity. Also, to the same end, I gave little attention to the authorization part of this demo. If you want to run this demo against your own Strava Account you will need to set your token secret in TokenRefresher.cs. Of course, never include these in your source control in a real development environment.

</div>
