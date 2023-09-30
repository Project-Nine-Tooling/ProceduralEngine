$PrevPath = Get-Location

Write-Host "Publish for Final Packaging build."
Set-Location $PSScriptRoot

$PublishFolder = "$PSScriptRoot\..\Publish"
$LibraryPublishFolder = "$PublishFolder\Libraries"
$NugetPublishFolder = "$PublishFolder\Nugets"

# Delete current data
Remove-Item $PublishFolder -Recurse -Force

# Publish Libraries
$PublishLibraries = @(
    "Main\ProceduralEngine\ProceduralEngine.csproj"
)
foreach ($Item in $PublishLibraries)
{
    dotnet publish $PSScriptRoot\..\$Item --use-current-runtime --output $LibraryPublishFolder
}
# Publish Nugets
$PublishNugets = @(
    "Main\ProceduralEngine\ProceduralEngine.csproj"
)
foreach ($Item in $PublishNugets)
{
    dotnet pack $PSScriptRoot\..\$Item --output $NugetPublishFolder
}

# Create archive
$Date = Get-Date -Format yyyyMMdd
$ArchiveFolder = "$PublishFolder\..\Packages"
$ArchivePath = "$ArchiveFolder\ProceduralEngine_Distribution_Build$Date.zip"
New-Item -ItemType Directory -Force -Path $ArchiveFolder
Compress-Archive -Path $PublishFolder\* -DestinationPath $ArchivePath -Force

# Validation
if (-Not (Test-Path (Join-Path $PublishFolder "Libraries\ProceduralEngine.dll")))
{
    Write-Host "Build failed."
    Exit
}

Set-Location $PrevPath