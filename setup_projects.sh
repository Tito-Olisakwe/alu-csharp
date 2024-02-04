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
