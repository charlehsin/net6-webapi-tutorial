# Tutorial and sample codes for unit testing

## Basic unit testing

- [Unit testing in VS Code](https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code)
- [Plural Sight: Unit testing in VS Code](https://www.pluralsight.com/guides/testing-.net-core-apps-with-visual-studio-code)

## Mock

- [Moq introduction](https://www.c-sharpcorner.com/article/moq-unit-test-net-core-app-using-mock-object/)
- [Moq in GitHub](https://github.com/moq/moq4/tree/fc484fb85)
- [Moq quick start](https://github.com/Moq/moq4/wiki/Quickstart)
- [Moq with task await](https://stackoverflow.com/questions/28581322/moq-with-task-await)

## ASP.NET related

- [Unit testing API controller](https://docs.microsoft.com/en-us/aspnet/web-api/overview/testing-and-debugging/unit-testing-controllers-in-web-api)

## .NET CLI

- [Unit testing CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test)
- [Run selected tests](https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest)

## Code coverage

- [Get code coverage](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows)

## Useful .NET CLI commands

- dotnet test
- (test project) dotnet test TodoApi.Tests.csproj
- (test target method) dotnet test --filter GetTodoItemsAsync
- (coverage) dotnet test --collect:"XPlat Code Coverage"
- (install coverage report tool) dotnet tool install -g dotnet-reportgenerator-globaltool
- (coverage report) reportgenerator -reports:"C:\Codes\net6-webapi-tutorial\TodoApi.Tests\TestResults\334eb5b6-f525-432a-ad59-97204b5a498b\coverage.cobertura.xml" -targetdir:"CoverageResults" -reporttypes:Html

## Useful Visual Studio Code extensions

- [Test explorer extension](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
