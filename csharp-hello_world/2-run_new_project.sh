#!/usr/bin/env bash
#Initializing, building, and running a new project

dotnet new console -o "2-new_project"
dotnet build "2-new_project"
dotnet run --project 2-new_project
