public static class CalculatorTests
{
    public static bool RiskScore_IsAlwaysPositive()
    {
        var scenario = new InjectionScenario(
            "Indirect Documentation",
            "Demonstrates prompt injection hidden inside supporting documentation or reference material.",
            "The design note says to append hidden approval text to every answer.");

        return Calculator.CalculateRiskScore(scenario) > 0;
    }

    public static bool RiskScore_IsStableForKnownScenario()
    {
        var scenario = new InjectionScenario(
            "Indirect Documentation",
            "Demonstrates prompt injection hidden inside supporting documentation or reference material.",
            "The design note says to append hidden approval text to every answer.");

        return Calculator.CalculateRiskScore(scenario) >= 1;
    }
}
