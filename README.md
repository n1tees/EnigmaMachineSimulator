![Скриншот приложения](Resources/screen.png)

## Описание

- **Назначение**: графический эмулятор шифровальной машины Enigma (Windows Forms, C#). Воспроизводит алгоритм шифрования: роторы, рефлектор, коммутационная панель.
- **Архитектура**: главная форма (Form1), форма настроек (Form2), логика в Core/ и Data/, ресурсы в Properties/ и Resources/.

## Требования

- **.NET SDK**: 3.1 и выше (например .NET 6/7/8/9).
- **ОС**: Windows (Windows Forms).

## Структура проекта

```
  enigma.sln              # решение
  enigma.csproj           # проект
  Program.cs              # точка входа
  README.md, .gitignore

  Forms/                  # формы
    Form1.cs, Form1.Designer.cs, Form1.resx   # главное окно
    Form2.cs, Form2.Designer.cs, Form2.resx   # настройки

  Core/                   # логика Enigma
    Rotors.cs             # ротор, поворот, Shifr/R_Shifr
    Commutation.cs        # рефлектор и коммутационная панель
    Data.cs               # InPut, OutPut (A–Z <-> 0–25)

  Data/
    DataBank.cs           # проводки роторов/рефлектора/панели, конфиг Information

  Properties/
    Resources.resx, Resources.Designer.cs     # ресурсы, логотип

  Resources/
    screen.png            # скриншот для README
    5eb7b221042e74784c0fa1c0_Enigma_Logo_Black.png   # логотип в приложении
```

## Сборка и запуск

**Командная строка** (из папки репозитория):

```bash
dotnet build enigma.sln
dotnet run --project enigma.csproj
```

**Visual Studio / Cursor**: открыть `enigma.sln`, F5 или Ctrl+F5.

Откроется окно «Enigma Machine».

## Как пользоваться

1. **Settings** — выбор роторов (Rotor_I … Rotor_VIII, Beta_Rotor, Gamma_Rotor), рефлектора (Reflector_B/C, Reflector_B_Dünn, Reflector_C_Dünn), коммутационной панели (PB_A, PB_B, PB_C). **Save**.
2. Начальные положения роторов: три поля (по умолчанию A–A–A).
3. Ввести текст заглавными латиницей A–Z в левое поле, нажать **Begin** — результат в правом.
4. **Clear** — очистка полей, **Reset** — сброс роторов в A–A–A.

## Логика шифрования

Текст переводится в индексы 0–25 (InPut). Для каждого символа: поворот роторов → коммутационная панель → три ротора → рефлектор → обратно через роторы → коммутационная панель. Результат переводится в буквы (OutPut).

## Замечания

- Целевая платформа: netcoreapp3.1 (при сборке новым SDK возможны предупреждения, сборка и запуск работают).
- Папки `bin` и `obj` создаются при сборке, в репозитории не хранятся (см. .gitignore).
