@echo off
dotnet pack Source\DGrok.Framework -o pub
dotnet publish Source\DGrok.Demo -r win-x64 -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained false -o pub
del pub\*.pdb
del pub\*.dll.config
