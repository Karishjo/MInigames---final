# 🎮 Angular Mini Games

A collection of interactive browser games built with Angular and Bootstrap.

The application features multiple games, score tracking, responsive layouts, and a customizable dark mode experience.

---

## Features

### 🧩 Formula Game
- Generate and solve mathematical expressions
- Multiple difficulty levels
- Real-time answer validation
- Score tracking
- Game instructions accordion

### 🎯 Hangman Game
- Random word generation
- Visual life tracker
- Letter guessing system
- Win/Loss detection
- Score tracking

### 🏆 Leaderboard
- Stores high scores
- Ranking display
- Top player statistics

### 🌙 Dark Mode
- Global theme toggle
- Consistent styling across all pages
- Bootstrap component customization
- Responsive color scheme

---

## Technologies Used

- Angular
- TypeScript
- Bootstrap 5
- HTML5
- SCSS

---

## Project Structure

```text
src/
├── app/
│   ├── formula/
│   ├── hangman/
│   ├── leaderboard/
│   ├── shared/
│   ├── services/
│   └── app-routing.module.ts
│
├── assets/
├── environments/
└── styles.scss
```

## Installation

Clone the repository:

```bash
git clone <repository-url>
```

Navigate to the project folder:

```bash
cd angular-mini-games
```

Install dependencies:

```bash
npm install
```

---

## Running the Application

Start the development server:

```bash
ng serve
```

Open the application in your browser:

```text
http://localhost:4200
```

The application will automatically reload whenever source files are modified.

---

## Build

Create a production build:

```bash
ng build
```

Build artifacts will be generated in:

```text
dist/
```

---

## Styling

The application supports both Light Mode and Dark Mode using CSS variables.

Example:

```scss
:root {
  --page-bg: #faf9f0;
  --page-text: #121435;
}

body.dark-mode {
  --page-bg: #222831;
  --page-text: #faf9f0;
}
```

Theme changes are applied globally across all pages and game components.

---

## Future Improvements

- Additional game modes
- Player profiles
- Player statistics dashboard
- Sound effects and animations
- Online leaderboard integration
- Persistent user preferences and settings

---

## Author

Developed by **KarishJo** as part of an Angular learning project.
