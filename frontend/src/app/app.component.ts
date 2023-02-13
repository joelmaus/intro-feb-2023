import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Learning Resource Application';
  subtitle = 'Angular is rad!';

  embiggenate(){
    this.subtitle = this.subtitle.toUpperCase();
  }
}
