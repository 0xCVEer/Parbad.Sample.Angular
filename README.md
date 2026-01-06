# How to run (Changs From Main Project)

## npm
```ps1
cd .\ClientApp\
npm i --legacy-peer-deps
$env:NODE_OPTIONS="--openssl-legacy-provider"

# Change package.json "@angular/etc.." version to fixed version
    "@angular-devkit/build-angular": "0.803.29",
    "@angular/cli": "8.3.29",
    "@angular/compiler-cli": "8.2.14",
    "@angular/language-service": "8.2.14",

    "@angular/animations": "8.2.14",
    "@angular/common": "8.2.14",
    "@angular/compiler": "8.2.14",
    "@angular/core": "8.2.14",
    "@angular/forms": "8.2.14",
    "@angular/platform-browser": "8.2.14",
    "@angular/platform-browser-dynamic": "8.2.14",
    "@angular/platform-server": "8.2.14",
    "@angular/router": "8.2.14",

    "typescript": "3.5.3"

npm start
```

## dotnet
```
1. Install .NET SDK

2. Change Parbad.Sample.Angular.csproj file:
    <TargetFramework>net10.0</TargetFramework>
3. dotnet restore
4. dotnet run
```