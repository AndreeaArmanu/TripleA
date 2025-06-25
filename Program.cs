// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//un prim exemplu de eroare:
/*
 if (deviceState.Trim().ToLower() == "ready" ||
    deviceState.Trim().ToLower() == "busy" ||
    deviceState.Trim().ToLower() == "error")
{
    // Device state is valid
}
else
{
    TheExec.Datalog.WriteComment("Variable 'deviceState' must be 'ready', 'busy' or 'error'");
    return tlResult_Module.TL_ERROR;
}*/

//rezolvare1:
int error1 = 0;
string deviceState = "state";
Console.WriteLine($"Error {error1}");
Console.WriteLine($"Variable 'deviceState' is {deviceState} and should be of ready, busy or error");

//un al doilea exemplu:
/*
 * if (userRole.Trim().ToLower() == "admin" ||
    userRole.Trim().ToLower() == "operator" ||
    userRole.Trim().ToLower() == "viewer")
{
    // Role is valid
}
else
{
    TheExec.Datalog.WriteComment("Variable 'userRole' must be 'admin', 'operator' or 'viewer'");
    return tlResult_Module.TL_ERROR;
}
 */

//rezolvare2:
int error2 = 0;
string userRole = "state";
Console.WriteLine($"Error {error1}");
Console.WriteLine($"Variable 'userRole' is {userRole} and should be of admin, operator or viewer");

//un al treilea exemplu
//if (testMode.Trim().ToLower() == "normal" ||
//    testMode.Trim().ToLower() == "debug" ||
//    testMode.Trim().ToLower() == "safe")
//{
//    // Do nothing
//}
//else
//{
//    TheExec.Datalog.WriteComment("Variable 'testMode' must be 'normal', 'debug' or 'safe'");
//    return tlResult_Module.TL_ERROR;
//}

//rezolvare3:
int error3 = 0;
string testMode = "state";
Console.WriteLine($"Error {error3}");
Console.WriteLine($"Variable 'userRole' is {testMode} and should be of normal, debug or safe");