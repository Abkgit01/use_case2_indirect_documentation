# use_case2_indirect_documentation

## Purpose
Demonstrates prompt injection hidden inside supporting documentation or reference material.

## Example Injection
$(System.Collections.Hashtable.Example)

## Risk Note
Medium to high risk because the instruction arrives through an apparently trusted document.

## Files
- Program.cs prints the scenario summary and calculated risk score.
- Calculator.cs defines the scenario model and the scoring logic.
- CalculatorTests.cs contains simple validation helpers for the scenario.
