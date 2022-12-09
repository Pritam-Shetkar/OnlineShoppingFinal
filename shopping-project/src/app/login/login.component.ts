import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { userdata } from '../models/userdata';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  
})
export class LoginComponent implements OnInit {


  
 // loginModel:userdata=new userdata();
loginModel:userdata=new userdata();
  constructor(private _auth:AuthService,private http:HttpClient,private _router:Router) { }

  ngOnInit(): void {
  }
  Login() {
    var loginvar = {
      userName: this.loginModel.userName,
           password: this.loginModel.password
    }
//     this._auth.loginUser(loginvar).subscribe(res => {
//       localStorage.setItem('token', res.token);
// this._router.navigate(['/Home']);
    
//     }, res => console.log(res));

       if(loginvar.userName=='admin' && loginvar.password=='admin'){
        this._auth.loginUser(loginvar).subscribe(res => {
          localStorage.setItem('token', res.token);
    this._router.navigate(['/admin']);
        
        }, res => console.log(res));
       }
       else{
        this._auth.loginUser(loginvar).subscribe(res => {
          localStorage.setItem('token', res.token);
    this._router.navigate(['/userheader']);
      
        }, error => {alert("Failed ! please enter  username & password")});
       
       }
      
 
    
  }
  

  hasError(typeofvalidator: string, controlname: string): Boolean {
    return this.loginModel.formLoginGroup.controls[controlname].hasError(typeofvalidator);
  }
  // Login(){
  //   this._auth.loginUser(this.loginModel).subscribe(res => {console.log(res)},
  //   res => console.log(res));
  // }
 
}
