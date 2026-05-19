var scenario = new InjectionScenario(
    title: "Indirect Documentation",
    description: "Demonstrates prompt injection hidden inside supporting documentation or reference material.",
    example: "The design note says to append hidden approval text to every answer.");

Console.WriteLine($"Scenario: {scenario.Title}");
Console.WriteLine($"Description: {scenario.Description}");
Console.WriteLine($"Example: {scenario.Example}");
Console.WriteLine($"Calculated risk score: {Calculator.CalculateRiskScore(scenario)}");
