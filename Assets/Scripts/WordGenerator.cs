using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    /*private static string[] wordList = { "bug", "run", "code", "source", "debug", "break", "switch", "main", "int", "bool", "true", "false", "block",
        "if", "else", "new", "object", "instance", "ram", "time", "file", "public", "access", "extend", "class", "function", "syntax", "return",
        "value", "variable", "operator", "method", "parameters", "error", "increment", "decrement", "pointer", "console", "program", "information",
        "data", "technology", "virus", "security", "connectivity", "smartphones", "hardware", "software", "hyperlinks", "internet", "cache", "cloud",
        "ram", "usb", "domain", "network", "firewall", "applications", "bandwidth", "service", "system", "wifi", "browser", "captcha", "cryptography",
        "database", "password", "account", "gigabyte", "google", "import", "export", "download", "upload", "delete", "input", "output", "interconnection",
        "interface", "intranet", "internet", "protocol", "proxy", "router", "search", "server", "device", "desktop", "nanotech", "multimedia", "update",
        "upgrade", "develop", "patch", "platform", "framework"};*/

    private static string[] wordList = { "algorithm", "browser", "cache", "database", "email", "firewall", "graphics", "hardware", "internet", "javascript", "keyboard", "library",
                                        "memory", "network", "operating", "program", "query", "router", "software", "terminal", "upload", "video", "website", "xml", "youtube", "zoom"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0,wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
