param(
    [string]
    # [parameter(mandatory = $true)]
    $SourceConnectionString = "Server=(localdb)\mssqllocaldb; Database=efmigration_to_sqldacpac_2_publish",
    [parameter(Mandatory = $true)]
    [String]
    $MigrationName
)

Start-Process sqlpackage.exe -ArgumentList "/a:Extract /SourceConnectionString:""$SourceConnectionString"" /TargetFile:$MigrationName.dacpac" -NoNewWindow -Wait

