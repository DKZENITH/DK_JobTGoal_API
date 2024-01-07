FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/DK_JobTGoal.Web.Host/DK_JobTGoal.Web.Host.csproj", "src/DK_JobTGoal.Web.Host/"]
COPY ["src/DK_JobTGoal.Web.Core/DK_JobTGoal.Web.Core.csproj", "src/DK_JobTGoal.Web.Core/"]
COPY ["src/DK_JobTGoal.Application/DK_JobTGoal.Application.csproj", "src/DK_JobTGoal.Application/"]
COPY ["src/DK_JobTGoal.Core/DK_JobTGoal.Core.csproj", "src/DK_JobTGoal.Core/"]
COPY ["src/DK_JobTGoal.EntityFrameworkCore/DK_JobTGoal.EntityFrameworkCore.csproj", "src/DK_JobTGoal.EntityFrameworkCore/"]
WORKDIR "/src/src/DK_JobTGoal.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/DK_JobTGoal.Web.Host", "src/DK_JobTGoal.Web.Host"]
COPY ["src/DK_JobTGoal.Web.Core", "src/DK_JobTGoal.Web.Core"]
COPY ["src/DK_JobTGoal.Application", "src/DK_JobTGoal.Application"]
COPY ["src/DK_JobTGoal.Core", "src/DK_JobTGoal.Core"]
COPY ["src/DK_JobTGoal.EntityFrameworkCore", "src/DK_JobTGoal.EntityFrameworkCore"]
WORKDIR "/src/src/DK_JobTGoal.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "DK_JobTGoal.Web.Host.dll"]
