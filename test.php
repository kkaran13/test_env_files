<?php
// ✅ True positives
$apiKey = getenv("API_KEY");
$dbPass = $_ENV["DB_PASS"];
$jwt = env("JWT_SECRET");

// ❌ False positives
$encoding = "utf-8";
$nullVal = null;
?>
