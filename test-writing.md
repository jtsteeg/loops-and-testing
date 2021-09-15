# Best practices for writing tests

## Summary

### Topics

## Estimated time
- Estimated time is twenty five minutes

## Resources
- MS Docs - [Unit testing best practices with .NET Core and .NET Standard](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
## Directions

### *What are the four reasons John Reese gives for writing unit test?*

Test driven development allows us to write working code faster and commit code with fewer bugs.

### *Explain each of johns 
- Fast
- Isolated
- Repeatable
- Self-checking
- Timely

I would add that a unit test *should not* test the framework, but only your code.  Think about testing the below code.

```csharp
public class CustomRandom
{
    public int GetRandomNumber(int min, int max)
    {
        var random = new Random();
        
        return random.Next(min, max); 
    }
}
```



