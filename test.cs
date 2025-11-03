using System;

public class EnvTest {
    public static void Main() {
        // ✅ True positives
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string dbPass = Configuration["DB_PASS"];
        string dbUser = Configuration["DB_USER"];

        // ❌ False positives
        string encoding = "UTF8";
        bool flag = false;
    }
}
