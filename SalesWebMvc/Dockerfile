#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

#Copia tudo e builda 
COPY . ./
RUN dotnet publish -c release -o out

#build com img do runtime
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

#entrypoint  ["dotnet", "SalesWebMvc.dll"]
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet SalesWebMvc.dll