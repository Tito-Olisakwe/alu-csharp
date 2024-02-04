# alu-csharp

Use the setup script like this:  ../setup.sh Project1 Project2 after navigating into the main directory of the set of tasks

e.g 
$ cd csharp-exceptions/
$ ../setup_projects.sh 0-safe_list_print 1-divide_print 2-divide_lists 3-throw_exception 4-throw_exception_msg

It deletes Program.sh
It changes the .csproj to:
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <LangVersion>7.0</LangVersion>
  </PropertyGroup>
</Project>

It creates an empty cs file with the dir name.