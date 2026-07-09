import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'minigames-ui';
  darkMode = false;

  toggleDarkMode() {

    this.darkMode = !this.darkMode;

    if (this.darkMode) {

      document.body.classList.add('dark-mode');

    } else {

      document.body.classList.remove('dark-mode');

    }
  }
}
