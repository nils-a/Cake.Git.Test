#addin nuget:?package=Cake.Git&version=1.0.1

var target = Argument("target", "Default");

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Default")
.Does(() => {
   var commits = GitLog(".", 10);
   foreach(var c in commits)
   {
      Information("> {0} {1}", c.Author.When, c.Author.Name);
      Information("  {0}", c.Sha);
      Information("  {0}",c.Message);
      Information("");
   }
});

RunTarget(target);
