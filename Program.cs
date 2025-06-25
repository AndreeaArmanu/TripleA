// See https://aka.ms/new-console-template for more information
using System.Globalization;


//err1
//if (deviceState.Trim().ToLower() == "ready" ||
//    deviceState.Trim().ToLower() == "busy" ||
//    deviceState.Trim().ToLower() == "error")
//{
//    // Device state is valid
//}
//else
//{
//    TheExec.Datalog.WriteComment("Variable 'deviceState' must be 'ready', 'busy' or 'error'");
//    return tlResult_Module.TL_ERROR;
//}

int error = 1;
string deviceState = "standby"; // val test inc
Console.WriteLine($"Error {error}");
Console.WriteLine($"Variable 'deviceState' is '{deviceState}' and should be one of: 'ready', 'busy', or 'error'");


//err2
//if (userRole.Trim().ToLower() == "admin" ||
//    userRole.Trim().ToLower() == "operator" ||
//    userRole.Trim().ToLower() == "viewer")
//{
//    // Role is valid
//}
//else
//{
//    TheExec.Datalog.WriteComment("Variable 'userRole' must be 'admin', 'operator' or 'viewer'");
//    return tlResult_Module.TL_ERROR;
//}

int error1 = 2;
string userRole = "guest"; // val incorecta
Console.WriteLine($"Error {error1}");
Console.WriteLine($"Variable 'userRole' is '{userRole}' and should be one of: 'admin', 'operator', or 'viewer'");

//err3
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
int error2 = 3;
string testMode = "advanced"; // val de test incorecta 
Console.WriteLine($"Error {error2}");
Console.WriteLine($"Variable 'testMode' is '{testMode}' and should be one of: 'normal', 'debug', or 'safe'");

