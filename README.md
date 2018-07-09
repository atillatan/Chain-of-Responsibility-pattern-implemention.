Chain Of Responsibility Pattern is the origin of middleware pipeline
=============================================

## DESCRIPTION

The Chain of Responsibility pattern is one of the twenty-three well-known "GoF design patterns"
ASP.NET Core applications uses "The Middleware Pipeline". 
The term “pipeline” implies that requests enter one end, are processed by each middleware component in turn, and exit the other end.  In reality, the run-time behavior is a variation of the Chain of Responsibility design pattern



## SIMPLE USAGE

```csharp
public class Program
{
    private static AppBuilder app = new AppBuilder();

    public static void Main(string[] args)
    {
        app.Use(new LogManager())
           .Use(new AuthorizationManager())
           .UseCacheManager();

        //Run 1
        app.Run("data");
    }
}
```


## AuthorizationManager

```csharp
public class AuthorizationManager : Middleware
{
    public AuthorizationManager()
    {
    }

    public override void Run(object request)
    {
        Console.WriteLine("Begin AuthorizationManager.");

        next?.Run(request);

        Console.WriteLine("End AuthorizationManager.");
    }
}
```

## CacheManager MIDDLEWARE

```csharp
public class CacheManager : Middleware
{
    public CacheManager()
    {
    }

    public override void Run(object request)
    {
        Console.WriteLine("Begin CacheManager.");

        next?.Run(request);

        Console.WriteLine("End CacheManager.");
    }
}

public static class CacheManagerExtension
{
    public static Middleware UseCacheManager(this Middleware middleware)
    {
        return middleware.Use(new CacheManager());
    }
}
```