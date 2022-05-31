:migrations
	SET /P migrationName=Name the migration: 
	echo %migrationName%
	CD ./GoodBooks.Data && dotnet-ef --startup-project ../GoodBooks.Web/ migrations add %migrationName% && cd ..
