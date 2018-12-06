import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { AuthService } from '../services/auth.service';
import { Form } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model = new User();

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  submit(form: Form) {
    console.log('Submitted');
    console.log(this.model);
    
  }

}
