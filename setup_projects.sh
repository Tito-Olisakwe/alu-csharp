# #!/bin/bash

# # Check if at least one argument is provided
# if [ $# -eq 0 ]; then
#     echo "Usage: $0 project_name [project_name...]"
#     exit 1
# fi

# # Iterate over all provided project names
# for project in "$@"; do
#     echo "Setting up project: $project"

#     # Create the task directory and navigate into it
#     mkdir "$project" && cd "$project"

#     # Initialize a new solution file
#     dotnet new sln

#     # Create the class library project
#     mkdir Text && cd Text
#     dotnet new classlib --framework net7.0
#     # Update the .csproj file to the required configuration
#     echo '<Project Sdk="Microsoft.NET.Sdk">
#   <PropertyGroup>
#     <TargetFramework>net7.0</TargetFramework>
#     <ImplicitUsings>enable</ImplicitUsings>
#     <Nullable>enable</Nullable>
#     <GenerateDocumentationFile>true</GenerateDocumentationFile>
#     <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
#   </PropertyGroup>
# </Project>' > Text.csproj
#     cd ..

#     # Add the class library project to the solution
#     dotnet sln add Text/Text.csproj

#     # Create the test library project
#     mkdir Text.Tests && cd Text.Tests
#     dotnet new nunit --framework net7.0
#     # Update the .csproj for the test project similarly
#     echo '<Project Sdk="Microsoft.NET.Sdk">

#   <PropertyGroup>
#     <TargetFramework>net7.0</TargetFramework>
#     <ImplicitUsings>enable</ImplicitUsings>
#     <Nullable>enable</Nullable>

#     <IsPackable>false</IsPackable>
#     <IsTestProject>true</IsTestProject>
#      <GenerateDocumentationFile>true</GenerateDocumentationFile>
#     <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
#   </PropertyGroup>

#   <ItemGroup>
#     <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.6.0" />
#     <PackageReference Include="NUnit" Version="3.13.3" />
#     <PackageReference Include="NUnit3TestAdapter" Version="4.4.2" />
#     <PackageReference Include="NUnit.Analyzers" Version="3.6.1" />
#     <PackageReference Include="coverlet.collector" Version="3.2.0" />
#   </ItemGroup>

#   <ItemGroup>
#     <ProjectReference Include="..\Text\Text.csproj" />
#   </ItemGroup>

# </Project>' > Text.Tests.csproj
#     # Add reference to the class library
#     dotnet add reference ../Text/Text.csproj
#     cd ..

#     # Add the test library project to the solution
#     dotnet sln add Text.Tests/Text.Tests.csproj

#     # Navigate back to the original directory
#     cd ..
# done

# echo "Setup complete."













#!/bin/bash

# Function to create a directory and set up the .NET project
setup_directory() {
    # Create the directory
    mkdir "$1"

    # Navigate into the directory
    cd "$1"

    # Initialize a new .NET console project
    dotnet new console

    # Delete the Program.cs file
    rm Program.cs

    # Find the .csproj file
    CS_PROJ_FILE=$(ls *.csproj)

    # Modify the .csproj file with new content
    echo '<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net7.0</TargetFramework>
        <LangVersion>latest</LangVersion>
        <DocumentationFile>bin/Debug/netcoreapp2.1/$1.xml</DocumentationFile>
    </PropertyGroup>
    </Project>' > "$CS_PROJ_FILE"

    # Create an empty C# file named after the directory
    touch "$1.cs"

    # Navigate back to the original directory
    cd ..
}

# Iterate over each argument provided to the script
for dir in "$@"
do
    setup_directory "$dir"
done
