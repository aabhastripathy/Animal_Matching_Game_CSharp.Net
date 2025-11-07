🦁 Animal Memory Game (WPF - C#)

A fun and interactive Memory Matching Game built using C# and WPF (Windows Presentation Foundation).
The goal is simple — match all pairs of animal emoji cards as quickly as possible! ⏱️🎮

🎯 Features

✅ 4×4 Grid Gameplay — 8 matching pairs placed randomly every game
✅ Timer with Millisecond Precision — powered by DispatcherTimer
✅ Match Detection — hides matched pairs and flips back mismatched ones
✅ High Score Tracking — stores fastest completion time during the session
✅ Click-Based Restart — click the timer area to play again
✅ Emoji-Based Cards — fun and visually engaging UI

🛠️ Technologies Used

C#

WPF & XAML

.NET Framework / .NET Core

DispatcherTimer for real-time updates

Event-driven UI programming (MouseDown events)



🚀 How to Run the Project

Clone the repository:

git clone https://github.com/yourusername/AnimalMemoryGame.git


Open the project in Visual Studio

Build and run the application

Click any card to start matching!

🎮 Game Rules

Click a tile → it reveals an animal emoji

Click another tile

✅ If both match → they disappear

❌ If not → they flip back

Timer starts automatically

After all 8 matches are found, the game:

Stops the timer

Displays your final time

Updates the best time (session high score)

Click the timer text to restart the game

📂 Code Breakdown
🔹 MainWindow.xaml

Defines the UI layout:

16 clickable TextBlocks

1 timer display at the bottom

🔹 MainWindow.xaml.cs

Handles all game logic:

SetUpGame() → randomizes emoji positions

Timer_Tick() → updates timer & checks for game completion

TextBlock_MouseDown() → manages reveal & match logic

TimeTextBlock_MouseDown() → restarts the game

✅ Future Improvements

Here are some enhancements planned (or ideas you can contribute to!):

✅ Flip animations for better visual feedback

✅ Sound effects for matches and mismatches

✅ Persistent high score using local storage or file system

✅ Multiple difficulty levels (4×4, 6×6, 8×8)

✅ Improved card UI (Borders or Buttons instead of TextBlocks)

🤝 Contributing

Pull requests are always welcome!
Feel free to open an issue if you’d like to add new features or improve the game.

📜 License

This project is open source and available under the MIT License.

⭐ If You Like This Project…

Give it a star ⭐ on GitHub — it helps motivate further improvements!

<img width="747" height="517" alt="Screenshot 2025-11-04 211725" src="https://github.com/user-attachments/assets/acc63ef9-17c9-4a95-be5b-204de6135410" />
<img width="740" height="494" alt="Screenshot 2025-11-04 211807" src="https://github.com/user-attachments/assets/d11e7361-2cb3-4428-8070-beb76b40607c" />

