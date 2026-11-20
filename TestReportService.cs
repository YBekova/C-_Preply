namespace C__Preply;

public class TestReportService
{
    public string GenerateReport(List<TestRun> tests)
    {
        var passedCount = 0;
        var failedCount = 0;
        var report = "";
        
        
        foreach (var test in tests)
        {
           var passed = test.IsPassed();
           var status = passed ? "PASSED" : "FAIL";
           
           report += test.Name + " - " + test.GetDuration + " - " + status + "\n";

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