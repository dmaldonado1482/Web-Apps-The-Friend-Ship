import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model = new User();
  constructor() { }

  ngOnInit() {
  }

  submit(form: NgForm) {
    console.log('Submitted');
    console.log(this.model);
  }

}
export class User {
  constructor() { }
}
