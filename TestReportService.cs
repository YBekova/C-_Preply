namespace C__Preply;

public class TestReportService
{
    public string GenerateReport(List<TestRun> tests)
    {
        int passedCount = 0;
        int failedCount = 0;
        string report = "";
        
        
        foreach (TestRun test in tests)
        {
           bool passed = test.IsPassed();
           string status = passed ? "PASSED" : "FAIL";
           
           report += test.Name + " - " + test.GetDuration() + " - " + status + "\n";

           if (passed)
           {
               passedCount++;
           }
           else
           {
               failedCount++;
           }
           
        }

        report += "Passed tests count: " + passedCount + "\n";
        report += "Failed tests count: " + failedCount + "\n";

        return report;
    }
}