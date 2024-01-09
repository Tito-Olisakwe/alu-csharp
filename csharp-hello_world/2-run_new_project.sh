#!/usr/bin/env bash
# Script to initialize, build, and run a new C# project

# Create a new directory for the project
mkdir -p 2-new_project

# Navigate to the directory
cd 2-new_project

# Initialize a new C# console application
dotnet new console

# Build the project
dotnet build

# Run the project
dotnet run
