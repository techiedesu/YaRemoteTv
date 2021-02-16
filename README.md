# YaRemoteTv [WIP]

Навык для использования "[Яндекс.Станция](https://yandex.ru/alice/station)" как ТВ приставку с пультом ДУ.

## Лицензия

Подробности в [LICENSE](/LICENSE).

## Docker

Для работы образа через https необходимо выполнить комманды ниже. Пожалуйста, разберитесь что они делают. Вы можете самостоятельно отключить https, создав `docker-compose.override.yml`.

 - PowerShell

```powershell
dotnet dev-certs https --clean
dotnet dev-certs https --trust -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p SECRETPASSWORD
```

 - Bash

```bash
dotnet dev-certs https --clean
dotnet dev-certs https --trust -ep $HOME/.aspnet/https/aspnetapp.pfx -p SECRETPASSWORD
```