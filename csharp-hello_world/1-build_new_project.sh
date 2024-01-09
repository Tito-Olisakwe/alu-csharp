#!/usr/bin/env bash
# Script to initialize and build a new C# project

# Create a new directory for the project
mkdir -p 1-new_project

# Navigate to the directory
cd 1-new_project

# Initialize a new C# console application
dotnet new console

# Build the project
dotnet build
