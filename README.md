# Reminder about circular dependencies in EF objects being sent as JSON

In this repo, I also demonstrated the problem we have when trying to send back EF objects, that have relationships, via JSON to the browser. The solution I demonstrated 
was to revert back to using the Newtonsoft.Json library. To do this, you'll first need to add the following package to your Web project:

```
Microsoft.AspNetCore.Mvc.NewtonsoftJson
```

Then, in your `Startup.cs` file, change the following line to look like this:

https://github.com/LITW08/ReactRouterDemo/blob/master/ReactRouterDemo.Web/Startup.cs#L23

Then, in your data project, you can choose to ignore whichever property you don't need to be sent along as part of the JSON:

https://github.com/LITW08/ReactRouterDemo/blob/master/ReactRouterDemo.Data/Car.cs#L13-L14

