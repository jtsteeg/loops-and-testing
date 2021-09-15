# Testing and Looping

## Summary
This activity explores different looping problems and has us practice writing tests.



## Resources
MS Docs - [Unit testing best practices with .NET Core and .NET Standard](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

MS Docs - [Nullable value types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types).

YouTube - [Design Patterns: Dependency Inversion Principle Explained Practically in C# (The D in SOLID)](https://www.youtube.com/watch?v=NnZZMkwI6KI&list=PLAaFb7UfyShCoS246UzZJNEiXuD8bg02e&index=5)

MS Docs - [Enumeration types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)

## Directions
There are three sections below:
- ForLoop Warm Up (ForLoop.cs)
- Writing Tests for GameGuessNumber 
- Simple Coding Problems And Test Writing

Work through each section with a partner.  Regularly take turns switching who is using the keyboard.  Be sure to change which computer you are working on:  After a while like each section, push the project to someone's repository, then the other person may clone the project and continue working on their machine.

## ForLoop Warm Up (ForLoop.cs) 

### Testing best practices
Start by reading [Unit testing best practices with .NET Core and .NET Standard](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices). Important topics include:
- What are characteristics of a good unit test?
- Code coverage is a measure used to describe the degree to which the source code of a program is executed when a particular test suite runs.  How important is high code coverage?
- What is a good strategy for naming your tests?
- How does the arrange, act, assert pattern work?
- A magic string is an input that a programmer believes will never come externally and which activates otherwise hidden functionality.  Why avoid magic string?

*In the examples, John Reese is using xunit for his testing, hence the attribute `[Fact]` in his examples.  In our test projects we are using MSTest, which uses the [TestMethod] attribute.  Both attributes mark tests similarly.*

### Nullable Types
*Quickly* look over examples of *[Nullable value types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types).* A nullable value type adds a ? to the value types (like int?) and allows the value type like an integer to also hold the value null.  Avoid using null value types unless necessary.

### Fix project errors
If you have not yet, clone the project and open it in visual studios.  
- https://github.com/Leap-Internal-Program/loops-and-testing


The project is not yet in a buildable state. There are errors stopping the project from working correctly.  First fix these errors:

- Add project reference for test project to main project
- Add access modifier to allows test project to access class in main project
- Add namespaces to test project
- Add missing attribute to test class

### Implement  the for loops
In this section, we will practice writing methods that pass certain tests.

Practice: **Get Lowest**

As a class together we will implement `int? GetLowest(int[] arr)` 
This method will return the lowest number from an array and returns null if the array is empty.
```
/// <summary>
/// Return lowest number in array
/// </summary>
/// <param name="arr">System.Int32[]</param>
/// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
```

Practice: **Get Highest**

Implement `int? GetHighest(int[] arr)` so it passes all three tests. The method should return the highest number in an array and returns null if the array is empty.
```
/// <summary>
/// Return highest number in array
/// </summary>
/// <param name="arr">System.Int32[]</param>
/// <returns>Returns highest number in array.  If array is empty, returns null</returns>
public int? GetHighest(int[] arr)
{

}
```

Practice: **Get Highest - Jagged Array**

Implement `int? GetHighest(int[][] arr)` so the method passes all tests.  The method should return the highest number in the jagged array and returns null if there are no numbers is in the array.

```
/// <summary>
/// Return highest number in jagged array
/// </summary>
/// <param name="arr">System.Int32[][]</param>
/// <returns>Returns highest number in array.  If there are no numbers provided, returns null</returns>
public int? GetHighest(int[][] arr)
{

}

```

## Writing Tests GameGuessNumber

### Dependency Injection

Watch [Design Patterns: Dependency Inversion Principle Explained Practically in C# (The D in SOLID)](https://www.youtube.com/watch?v=NnZZMkwI6KI&list=PLAaFb7UfyShCoS246UzZJNEiXuD8bg02e&index=5)

*Quickly* look over examples of *[Enumeration types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum).* An enumeration type (or enum type) is a value type defined by a set of named constants.  Underlying enums are numbers.  In many ways an enum provides clarity in the code and often used to replace what otherwise would be a "magic" string or number.

## 

Practice: **Finish writing the tests for someone else's code**

Finish writing the remaining two tests in `GuessNumber_tests.cs`.  Do not just copy the code the first example, but debug the first test to understand how the program works and then write the new tests.  Notice that there is a UserInterface_mock class that allows the test writer to provide user input.  Notice how "magic" strings are not used to help others understand the code.

The GameGuessNumber class depends on the UserInterface. (As an aside, this pattern of providing the dependency injection as an argument.  A more common pattern may be a singleton in this scenario).

```csharp
public class GuessNumber_tests
    {
        [TestMethod]
        public void Guess_HigherThanAnswer_ReturnsResponseHigher()
        {
            //Arrange
            var ui = new UserInterface_mock();
            var answer = 8;
            var guess = 9;
            var expected = GuessResponse.Higher;
            ui.AddToNumberQueue(guess);
            var sut = new GameGuessNumber(answer, ui);

            //Act
            var result = sut.Guess();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Guess_LowerThanAnswer_ReturnsResponseLower()
        {

        }

        [TestMethod]
        public void Guess_EqualToAnswer_ReturnsResponseHigher()
        {

        }
    }

```

## Simple Coding Problems and Test Writing
This is a list of problems to solve with your partner.  In this section you will be writing tests and solving the problem.  Over the coming weeks we will be exploring algorithms and these problems may be categorized as "algorithm problems." A definition for an algorithm is:

> A well-defined computational procedure that takes some value or set of values as input and produces some values or set of values as output.

Or more simply 
1) There is an input, like a number
2) Code is run
3) There is an output, like a different number.

This is simple definition for now.  Constraints are also often provided for algorithm type problems.  Contstraints are limitations or restrictions when solving the problem.  Most often a constraint is clarifying an "input" type or the bounds of an input.  For example the contraint: *1 <= s.length <= 100* means the method needs only to expect a string between the lengths of 1 and 100 inclusive.

**Be sure to write tests as you code each of these problems.  The most important part of the exercise is writing the tests.**

You will want to make new classes and new test classes for each of these problems.

### Problem: *Given a string *input*, return the string with the characters reversed.*
| *Example 1:*|  |
| :-- | :-- |
| Input| "hello" | 
| Output | "olleh" |

| *Example 2:* | |
| :-- | :-- |
| *Input: | "h" |
| Output: | "h" |

| *Example 3:* | |
| :-- | :-- |
| Input: | "Great race" |
| Output: | "ecar taerg" |
 
*Constraints:*
-  1 <= input.length <= 100
- s consists of characters with ASCII values in the range [33, 122].
- s does not contain '\"' or '\\'

### Problem: Does Double Exist?
Given an array of integers, check if there exists two integers such that one is double the another (E.g. 3 and 6.  Six is twice of 3).

A more formal way of explaining this problem is:
```
check if there exists two indices i and j such that:
i != j
0 <= i, j < arr.length
arr[i] == 2 * arr[j]
```

| Example 1: | |
| :-- | :-- |
| Input: | [10,2,5,3] |
| Output: | true |

Explanation: 10 is the double of 5, that is, 10 = 2 * 5.

| Example 2: | |
| :-- | :-- |
| Input: | [7,1,14,11] |
| Output: | true |

Explanation: 14 is the double 7, that is, 14 = 2 * 7.

| Example 3: | |
| :-- | :-- |
| Input: |[3,1,7,11] |
| Output: | false |

Explanation: In this case does not exist any number that is a double of another number |
 
|Constraints:|
| :-- |
|2 <= arr.length <= 500 |
|-10^3 <= arr[i] <= 10^3 |

*Hint: the fastest way to solve this problem is using a data structure we haven't learned yet.  For now, try using loops.*

### Optional Problem: Is string a palindrome

#### This problem is optional if you have time remaining

Given an input string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases. A palindrome is a word, phrase, or sequence that reads the same backward as forward.

| Example 1 | |
| :-- | :-- |
| Input: | "racecar" |
| Output: |  true |

Explanation: "racecar" is a palindrome.

| Example 2: | |
| :-- | :-- |
| Input: | "race a car" |
| Output: |  false |

Explanation: "raceacar" is not a palindrome.

| Example 3: | |
| :-- | :-- |
| Input: s | "A man, a plan, a canal: Panama |
| Output: | true |

Explanation: "amanaplanacanalpanama" is a palindrome.


| Constraints |
| :-- |
| 1 <= str.length <= 2 * 105 |
| The string only consists of printable ASCII characters. |