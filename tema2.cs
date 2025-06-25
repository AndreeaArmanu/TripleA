// See https://aka.ms/new-console-template for more information
using System.Globalization;
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
}
 */

int error1= 0;
string deviceState = "state";
Console.WriteLine($"Error {error1}");
Console.WriteLine($"Variabilele 'deciceState' is {deviceState} and should be of type ready, busy, error");


/*
 if (userRole.Trim().ToLower() == "admin" ||
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

int error2 = 0;
string userRole = "user";
Console.WriteLine($"Error {error2}");
Console.WriteLine($"Variabilele 'userRole' is {userRole} and should be of type admin,operator, viewer");

/*
if (testMode.Trim().ToLower() == "normal" ||
    testMode.Trim().ToLower() == "debug" ||
    testMode.Trim().ToLower() == "safe")
{
    // Do nothing
}
else
{
    TheExec.Datalog.WriteComment("Variable 'testMode' must be 'normal', 'debug' or 'safe'");
    return tlResult_Module.TL_ERROR;
}
*/


int error3 = 0;
string testMode= "test";
Console.WriteLine($"Error {error3}");
Console.WriteLine($"Variabilele 'testMode' is {testMode} and should be of type normal, debug, safe");