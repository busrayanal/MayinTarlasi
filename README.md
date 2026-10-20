# 💣 Minefield (C# WinForms)

🇬🇧 **English** | [🇹🇷 Türkçe](README.tr.md)

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.7.2-512BD4?logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?logo=windows&logoColor=white)

A minefield game built with C# Windows Forms. The player starts at the **top-left corner** of a 20x20 grid and moves with the arrow buttons, trying to reach the **goal at the bottom-right corner without stepping on a mine**.

<p align="center">
  <img width="700" alt="Game screen" src="https://github.com/user-attachments/assets/e8a5f727-7ace-4d16-b8dc-a5df6a7069b9" />
</p>

> [!NOTE]
> The game's user interface and the code comments are in Turkish.

## 🕹️ How to Play

1. Enter your player name.
2. Choose a difficulty level. Mines are placed randomly on the grid.
3. Move with the **⬆️ ⬇️ ⬅️ ➡️** buttons. The timer starts on your first move.
4. The **"Mayınlara Yakın"** (*Nearby Mines*) counter shows how many mines are directly next to your cell (up, down, left, right). Use this hint to find a safe path.
5. Reach the bottom-right corner to **win**. Step on a mine and the **game is over**, and all mines are revealed.

## ✨ Features

| Feature | Description |
|---|---|
| 🗺️ Game board | 20x20 grid |
| 🎚️ Difficulty levels | Easy (40 mines), Medium (50 mines), Hard (80 mines) |
| 🧭 Mine hint | Number of nearby mines is shown in real time |
| ⏱️ Timer | Game time is tracked with a Timer |
| 🏆 Scoreboard | Each game's result (name, time, won/lost) is saved to `skorlar.txt` and can be viewed in the app |
| 🚧 Boundary check | The player can't move outside the board |
| 🔁 New game | Restart with one click when the game ends |

## 🎯 Purpose of the Project

This project was built to learn and reinforce game logic:

- Learning arrays, conditionals (if), loops and events
- Using a `Timer` and file operations (`File`)
- Understanding game logic step by step

> [!NOTE]
> Repeated code could normally be refactored into functions to make it shorter. In this project, however, some code is repeated **on purpose** so each step of the logic stays easy to follow.

## 🧰 Technologies

- C#
- Windows Forms (.NET Framework 4.7.2)
- Visual Studio
- [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms): NuGet package for UI components

## ▶️ Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/busrayanal/MayinTarlasi.git
   ```
2. Open `MayinTarlasi.sln` in **Visual Studio**.
3. Visual Studio restores the missing NuGet package (Guna.UI2) automatically. If it doesn't: *right-click the Solution → Restore NuGet Packages*.
4. Press **F5** to run.

## 📁 Project Structure

```
MayinTarlasi/
├── MayinTarlasi.sln          # Visual Studio solution file
└── MayinTarlasi/
    ├── Form1.cs              # Game logic (movement, mine checks, scores)
    ├── Form1.Designer.cs     # UI layout
    ├── Program.cs            # Application entry point
    └── Resources/            # Images (mine, arrow buttons, icons)
```

## 📸 Screenshots

| During the game | Finished game |
|:---:|:---:|
| <img width="300" alt="Moving without hitting a mine" src="https://github.com/user-attachments/assets/af10b31d-1865-477e-a3de-fbb16c1ec934" /> | <img width="400" alt="Finished game" src="https://github.com/user-attachments/assets/6dbf1ecc-6e35-4f9b-aa7b-d045b33da585" /> |

| Name entry | Help | Scores |
|:---:|:---:|:---:|
| <img width="280" alt="Name entry" src="https://github.com/user-attachments/assets/bb803b09-42e4-49d0-8cc3-1de2ddd6c650" /> | <img width="220" alt="Help" src="https://github.com/user-attachments/assets/573b04c2-00fb-446f-ac17-3c3f2304cfb0" /> | <img width="130" alt="Scores" src="https://github.com/user-attachments/assets/4dce00d6-655b-4212-a425-a01d753f866b" /> |

## 👩‍💻 Developer

**Büşra Amine Yanal** · [GitHub](https://github.com/busrayanal)
