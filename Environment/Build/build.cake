///////////////////////////////////////////////////////////////////////////////
// Include
///////////////////////////////////////////////////////////////////////////////
#load solution.cake

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(context =>
{
   // Executed BEFORE the first task.
   Information("Running Setup");
});

Teardown(context =>
{
   // Executed AFTER the last task.
   Information("Running Teardown.");
});

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Default")
.Does(() => {
   Information("Running Default.");
});

RunTarget(target);