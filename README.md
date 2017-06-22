# fib

### Environment Setup Guide
- Install [dotnet core 1.0.4 sdk for your OS](https://www.microsoft.com/net/download/core)
- Install [vscode for your OS](https://code.visualstudio.com/)
- Install the [csharp module for vscode](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

### Quickstart Guide
- Clone the repo with your preferred flavor of git
- Navigate to the fib directory: `cd fib`
- Restore required packages `dotnet restore`
- Open vscode `vscode .`

### Testing Guide
```
dotnet test tests/fib.tests/fib.tests.csproj
```