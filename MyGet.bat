dotnet restore src/myget.sln
msbuild src/myget.sln  /t:pack /p:Configuration=Release
