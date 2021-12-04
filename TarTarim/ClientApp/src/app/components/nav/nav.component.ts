import { AuthService } from './../../services/auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  constructor(private authService:AuthService) { }
  isAuthenticated:boolean;
  
  ngOnInit(): void {
    this.isAuthenticated=this.authService.isAuthenticated()
  }
  logOut(){
    this.authService.logout()
  }
}
