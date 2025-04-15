#tool nuget:?package=StyleCop.Analyzers

var projectPath = "./TestProject/TestProject.csproj";
var testPath = "./TestProject/TestProject.csproj";
var docOutput = "./TestProject/html";

Task("Clean")
    .Does(() =>
{
    CleanDirectory("bin");
    CleanDirectory("obj");
    CleanDirectory(docOutput);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetRestore(projectPath);
    DotNetRestore(testPath);
});

Task("Build-Debug")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetBuild(projectPath, new DotNetBuildSettings {
        Configuration = "Debug"
    });
});

Task("Build-Release")
    .IsDependentOn("Build-Debug")
    .Does(() =>
{
    DotNetBuild(projectPath, new DotNetBuildSettings {
        Configuration = "Release"
    });
});

Task("Analyze")
    .IsDependentOn("Build-Release")
    .Does(() =>
{
    Information("Analyzers are enforced during build with TreatWarningsAsErrors.");
});

Task("Format")
    .IsDependentOn("Analyze")
    .Does(() =>
{
    StartProcess("dotnet", "format --verify-no-changes");
});

Task("Test")
    .IsDependentOn("Format")
    .Does(() =>
{
    DotNetTest(testPath);
});

Task("Docs")
    .Does(() =>
{
    StartProcess("doxygen", "./TestProject/Doxyfile");
});

Task("Default")
    .IsDependentOn("Docs")
    .IsDependentOn("Test");

RunTarget("Default");
