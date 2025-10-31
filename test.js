// ✅ True positives
const apiKey = process.env.API_KEY;
const token = process.env["ACCESS_TOKEN"];
const secret = getEnv("JWT_SECRET");
const configValue = config.get("DB_URL");

// ✅ Alternate patterns
const custom = dotenv.config().CUSTOM_ENV;

// ❌ False positives
let format = "json";
let undefinedVar = undefined;
const status = "true";
