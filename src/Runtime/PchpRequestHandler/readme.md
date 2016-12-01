Request Handler for ASP.NET Integrated Pipeline (IIS 7 and newer, IIS Express)

The project exposes `System.Web.IHttpHandler` implementation that handles ASP.NET requests to be passed to PHP scripts in a compiled assembly.

## Usage

1. Copy `Peachpie.RequestHandler.dll` (former `PchpRequestHandler.dll`) into *webroot\bin*;
2. Alter your `web.config` and insert following XML fragment into `<configuration><system.webServer>`
``` <add name="PhpHandler" path="*.php" verb="*" type="Pchp.Core.RequestHandler, Pchp.RequestHandler" preCondition="integratedMode" /> ```
3. Deploy compiled PHP scripts to *webroot\bin*