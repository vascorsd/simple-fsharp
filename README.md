# simple-fsharp

Simple template for F# (fsharp). Trying to learn the tooling
and making somekind of consistent structure to quickly jump
between other projects on different languages.


## Description

This is more or less following the official docs on MS site to learn
the language and the tooling.

This template basically requires the dotnet sdk which brings 
what's needed to work with C# and F# or dotnet ecosystem. 
And yes, it's all more or less working fine on linux.

It seems dotnet -sdk versions are basically similar to jdk when
choosing a version. Currently dotnet-7 is the latest, dotnet-6 the
LTS version.

On linux (archlinux tested only), both versions can be installed
at same time by installing `dotnet-sdk-6.0` and `dotnet-sdk`.
This will install the tool `dotnet` wich we can interact with to build
projects, package, compile, release, etc.


### Details

The bootstrap of the current folder was done following these steps:
  - `dotnet new sln -o simple-fsharp`
  - `cd simple-fsharp`
  - `git init`
  - `dotnet new gitignore`
  - `dotnet new console -lang "F#" -o src/bin-console`
  - `dotnet new classlib -lang "F#" -o src/lib`
  - `dotnet sln add src/bin-console/bin-console.fsproj`
  - `dotnet sln add src/lib/lib.fsproj`
  - `dotnet add src/bin-console/bin-console.fsproj reference src/lib/lib.fsproj`

The specific sdk version being target is defined in each project file
in the xml tag `TargetFramework`. Currently uses the latest `net7.0`.
It's possible to target more than on sdk at same time by changing the 
name to `TargetFrameworks` and add a comma between each target like 
`net6.0, net7.0` (this requires both sdks to be installed at same time
to be able to build it.


### Gettting started with dotnet projects

Having the dotnet tool installed and respective sdks, the most common
operation seem to be:
  - `dotnet restore` - gets all library dependencies for the project
                       (it's basically restoring from a .lock file)
  - `dotnet clean` - cleans the build artifacts
  - `dotnet build` - compiles the things
  - `dotnet run --project src/bin-console` - to run the specific thing.
                      (instead of using --project we can move directly to the
                      folder and simply issue a plain dotnet run. Parameters
                      afterwards are passed to the application. We can also
                      use -f net6 to control the dotnet version to run under)
  - `dotnet publis -c Release` - compiles and optimizes the binary for distribution.
                      To run it after that either: `src/bin-console/bin/Release/net7.0/bin-console` or
                      `dotnet src/bin-console/bin/Release/net7.0/bin-console.dll`.
                      I'm not sure what is the difference at this point.

As for IDE, vscode/vscodium seems to only need the following extensions:
  - C# for Visual Studio Code (powered by OmniSharp)
  - Ionide for F#
  - solution-syntax


