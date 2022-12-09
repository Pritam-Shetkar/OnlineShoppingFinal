import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
 // selector: 'app-master',
 selector: 'app-root',
  templateUrl: './master.component.html'  
})
export class MasterComponent implements OnInit {
//  constructor(private _auth: AuthService, private _router: Router) { }
constructor(private _auth: AuthService,private _router: Router){}
  ngOnInit(): void {
  }
  Logout(){
    this._auth.logoutUser();
    this._router.navigate(['/Home']);
  }

  LogggedIn(Input:boolean):boolean{
    if(Input){
      return this._auth.loggedIn();
    }
    else{
      return !this._auth.loggedIn();
    }
  }
}
