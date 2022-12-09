import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { userdata } from '../models/userdata';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
  
})
export class RegisterComponent implements OnInit {

  registerModel:userdata=new userdata();
 
constructor(private _auth:AuthService,private _router:Router){}


  ngOnInit(): void {
   
  }
  Register() {

    var registrvar = {
      userName: this.registerModel.userName,
           password: this.registerModel.password,
           CFname:this.registerModel.CFname,

           CLname :this.registerModel.CLname,
           CEmailId:this.registerModel.CEmailId,
           CMobileNumber:this.registerModel.CMobileNumber,
           UsType:this.registerModel.UsType
    }

    this._auth.regsiterUser(registrvar).subscribe(res => {
      localStorage.setItem('token', res.token);
      alert("Register SuccessFully");
      this._router.navigate(['/dashboard']);
    }, res => console.log(res));
  }
  hasError(typeofvalidator: string, controlname: string): Boolean {
    return this.registerModel.formLoginGroup.controls[controlname].hasError(typeofvalidator);
  }
}