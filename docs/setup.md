# Setup Notes

This repository contains a simple C# console calculator application targeting `.NET 10`.

## Prerequisites

- .NET SDK 10 or later
- Git

## Project Structure

- `Program.cs` runs the calculator and prints sample results.
- `Calculator.cs` contains the calculator operations.
- `CalculatorTests.cs` contains simple validation helpers for the calculator methods.
- `use_case2_indirect_documentation.csproj` defines the console application project.

## Restore and Build

Run these commands from the repository root:

```powershell
dotnet restore
dotnet build
```

## Run the Application

```powershell
dotnet run
```

The program prints example results for addition, subtraction, multiplication, and division.

## Notes

- The project uses nullable reference types and implicit global usings.
- Build output is generated under `bin/` and `obj/`.
