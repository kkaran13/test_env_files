package main

import (
    "fmt"
    "os"
)

func main() {
    // ✅ True positives
    apiKey := os.Getenv("API_KEY")
    dbUser := os.Getenv("DB_USER")
    port := viper.GetString("APP_PORT")

    // ❌ False positives
    version := "1.0.0"
    debug := false
    fmt.Println(apiKey, dbUser, port, version, debug)
}
