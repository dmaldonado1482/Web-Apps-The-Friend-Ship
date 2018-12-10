import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { User } from '../models/user';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model = new User();
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  submit(form: NgForm) {
    console.log('Submitted');
    console.log(this.model);
    this.authService.login(this.model).subscribe();
  }
}

