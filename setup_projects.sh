#!/bin/bash

# Function to create a directory and set up the .NET project
setup_directory() {
    # Create the directory
    mkdir "$1"

    # Navigate into the directory
    cd "$1"

    # Initialize a new .NET console project
    dotnet new console

    # Modify the Program.cs file to comment out the Console.WriteLine line
    sed -i 's/Console.WriteLine/\/\/ Console.WriteLine/g' Program.cs

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
