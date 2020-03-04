using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static string username;
    public static int escore;
    public static int mscore;
    public static int sscore;

    public static bool LoggedIn { get { return username != null; } }

}
