using System;

public class EnvTest {
    public static void Main() {
        // ✅ True positives
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string dbPass = Configuration["DB_PASS"];
        string dbUser = Configuration["DB_USER"];
        string dbAdmin = Configuration["DB_ADMIN"];

        // ❌ False positives
        string encoding = "UTF8";
        bool flag = false;
    }
}
