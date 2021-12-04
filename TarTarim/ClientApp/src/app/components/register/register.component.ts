import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ClaimModel } from 'src/app/models/claimModel';
import { RegisterModel } from 'src/app/models/registerModel';
import { AuthService } from 'src/app/services/auth.service';
import { TokenService } from 'src/app/services/token.service';
import {OperationClaimService} from "../../services/operation-claim.service";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  constructor(
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private tokenService: TokenService,
    private toastrService: ToastrService,
    private operationClaimService:OperationClaimService
  ) {}
  claims:ClaimModel[]
  ngOnInit(): void {
    this.createLoginForm();
    this.operationClaimService.getClaims().subscribe(r=>this.claims=r.data);
  }

  registerForm: FormGroup;
  createLoginForm() {
    this.registerForm = this.formBuilder.group({
      firstName: new FormControl('', Validators.required),
      lastName: new FormControl('', Validators.required),
      email: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
      operationClaim: new FormControl('', Validators.required),
    });
  }
  register() {
    if (this.registerForm.valid) {
      let registerDto: RegisterModel = Object.assign(
        {},
        this.registerForm.value
      );

      this.authService.register(registerDto).subscribe(
        (response) => {
          this.tokenService.setToken(response.data);
          this.toastrService.success(response.message);
          window.history.go(0);
        },
        (errorResponse) => {
          console.log(errorResponse);
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
