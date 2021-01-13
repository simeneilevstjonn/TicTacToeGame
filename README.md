# Tic Tac Toe Game

A simple Tic tac toe game that I created in Windows forms.
It allows you to play against an AI, avaliable in three difficulties.

## Installation
You may clone the repo and build the program using `dotnet build`. This requires that you have .NET Core SDK 3.1 installed on your computer.

## AI
The AI has three difficulties; easy, medium and difficult. 
When in difficult mode, the AI calculates it's and your possibilities for victory, and does it's turn based on that.
In medium mode, it performs the same calculations as in hard mode, but there is a chance that it will ignore it, and just choose a random number.
In easy mode, the AI will just input random numbers.

## Scoreboard
The program counts scores from player and AI, as well as the amount of games that ended with a tie.

