<?php
// ✅ True positives
$apiKey = getenv("API_KEY");
$dbPass = $_ENV["DB_PASS"];
$jwt = env("JWT_SECRET");
$jwtKey = env("JWT_KEY");
$admindbPass = $_ENV["ADMIN_DB_PASS"];
$dbUser = getenv("DB_USER");
$devdbUser = env("DEV_DB_USER");

// ❌ False positives
$encoding = "utf-8";
$nullVal = null;
?>
