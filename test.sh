# ✅ True positives
export DB_USER="root"
export DB_PASS="password"
export API_TOKEN=$API_KEY
echo "Running with $DB_USER and ${DB_PASS}"

# ❌ False positives
echo "true false null undefined"
FLAG=false
