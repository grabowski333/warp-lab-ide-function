# IdeFunctionLab

## Cel

Program oblicza wartość funkcji `f(x) = 2x + 3`. Wartość `x` można zmienić w pliku `Program.cs`.

## Uruchomienie

W terminalu, w folderze projektu, wpisz:

```text
dotnet run
```

Dla `x = 4` program wyświetla `f(4) = 11`.

## Sprawdzenie w IDE

- **Visual Studio Code:** projekt zbudował się i uruchomił. Wynik: `f(4) = 11`. Debugger zatrzymał się w funkcji `Calculate`; zmienna `value` miała wartość `4`.
- **Visual Studio Community 2026:** projekt został otwarty. Kompilacja narzędziem MSBuild z Visual Studio zakończyła się powodzeniem, bez ostrzeżeń i błędów. Uruchomienia i debugowania z poziomu IDE nie udało się potwierdzić.
- **JetBrains Rider:** projekt zbudował się i uruchomił. Wynik: `f(4) = 11`. Debugger pokazał `value = 4`, a po obliczeniu `result = 11`.

## Debugowanie

Plik `.vscode/launch.json` zawiera ustawienia startu debuggera w Visual Studio Code, a `.vscode/tasks.json` opisuje kompilację przed uruchomieniem.

## Repozytorium
https://github.com/grabowski333/warp-lab-ide-function

