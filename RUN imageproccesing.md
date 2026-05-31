# Инструкция по запуску ImageProccesingApp

## Что не так в этой ветке

В этой ветке файл решения называется:

```powershell
ImageProccesingApp 2attempt.sln
```

Старой команды больше недостаточно:

```powershell
dotnet build "ImageProccesing PetyaApp.sln"
```

Она падает с `MSB1009`, потому что файла `ImageProccesing PetyaApp.sln` в текущей ветке нет.

## Правильная команда сборки

Из корня проекта:

```powershell
dotnet build "ImageProccesingApp 2attempt.sln"
```

## Требования

Проект является старым Windows Forms проектом под `.NET Framework 4.7.2`, а не современным `.NET 10` проектом.

Для сборки нужны:

- Visual Studio с компонентом `.NET desktop development`
- `.NET Framework 4.7.2 Developer Pack` / targeting pack
- восстановленные NuGet-пакеты из `ImageProccesingApp 2attempt\packages.config`

Если Developer Pack не установлен, сборка падает с ошибкой:

```text
MSB3644: не найдены ссылочные сборки для .NETFramework,Version=v4.7.2
```

## Восстановление пакетов

В этой ветке проект ссылается на пакеты из папки `packages`, например `App.Metrics`, `CircularProgressBar`, `WinFormAnimation` и другие. Если папки `packages` нет, восстановите пакеты:

```powershell
nuget restore "ImageProccesingApp 2attempt.sln"
```

Либо откройте решение в Visual Studio, и Visual Studio предложит восстановить NuGet-пакеты автоматически.

## Запуск

После успешной сборки запускайте:

```powershell
.\ImageProccesingApp 2attempt\bin\Debug\ImageProccesingApp 2attempt.exe
```

