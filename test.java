public class EnvExample {
    public static void main(String[] args) {
        // ✅ True positives
        String dbUrl = System.getenv("DB_URL");
        String apiKey = System.getProperty("API_KEY");
        String pass = env.getString("DB_PASSWORD");
        @Value("${AUTH_TOKEN}")
        String token;
        String adminapiKey = System.getProperty("ADMIN_API_KEY");

        // ❌ False positives
        String encoding = "UTF-8";
        boolean flag = false;
    }
}
