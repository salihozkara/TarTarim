import { LoginModel } from './../../models/loginModel';
import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from 'src/app/services/auth.service';
import { TokenService } from 'src/app/services/token.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  constructor(
    private authService: AuthService,
    private toastrService: ToastrService,
    private tokenService: TokenService,
    private formBuilder: FormBuilder
  ) {}

  ngOnInit(): void {
    this.createLoginForm();
  }

  loginForm: FormGroup;
  createLoginForm() {
    this.loginForm = this.formBuilder.group({
      email: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
    });
  }

  login() {
    if (this.loginForm.valid) {
      let loginDto: LoginModel = this.loginForm.value;
      this.authService.login(loginDto).subscribe(
        (response) => {
          this.tokenService.setToken(response.data); //token service üzerinden kayıt ediliyor
          this.toastrService.success(response.message);
          window.history.go(0);
        },
        (errorResponse) => {
          this.toastrService.error(errorResponse.error, 'Hata');
        }
      );
    } else {
      this.toastrService.warning(
        'Lütfen gerekli alanları istenilen biçimde doldurunuz.',
        'Model Doğrulama Uyarısı'
      );
    }
  }
}
