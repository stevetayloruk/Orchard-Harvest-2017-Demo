import { Component } from '@angular/core';

@Component({
  //moduleId: module.id,
  selector: 'newsletter-signup',
  templateUrl: 'app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {

    subscribedEmail = '';
    submitted = false;

    subscribe() {
        this.submitted = true;
    }

}
