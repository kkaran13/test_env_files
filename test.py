import os
import dotenv

# ✅ True positives
api_key = os.getenv("API_KEY")
db_pass = os.environ["DB_PASSWORD"]
debug_mode = os.environ.get("DEBUG_MODE")
dotenv.get_key(".env", "JWT_SECRET")
db_user = os.getenv("DB_USER")

# ✅ Alternate patterns
config_value = settings("SERVICE_TOKEN")

# ❌ False positives
encoding = "utf-8"
self = "something"
print("true", "false", "none")
