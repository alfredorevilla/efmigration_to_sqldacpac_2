# EF Migration to SQL DACPAC POC

## Motivation
To allow creating DACPAC from EF Migrations without creating or relying on a SQL Project.

## Status
Currently, DACPACS are manually created. A PowerShell script could be added that streamlines the DB Update and DACPAC file creationg.

## Steps

- Update DB using EF Migrations
- Create a new DACPAC using the following command:
    ```pwsh
    Add-DacPac.ps1 -FileName <string> [-SourceConnectionString=<string>]
    ```