& dnu restore .\ElasticsearchClient\project.json 2>1
& "$env:msbuildexe" .\MyGet.sln /p:Configuration=$env:Configuration /m /v:M /fl /flp:LogFile="msbuild.log;Verbosity=Normal" /nr:false 2>1