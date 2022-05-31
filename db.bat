:db
	cd ./GoodBooks.Data && dotnet-ef --startup-project ../GoodBooks.Web/ database update && cd ..