import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';


import { MasterComponent } from './master/master.component';
import { Mainroutes } from './routing/mainroutes';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { SearchproductbynameComponent } from './searchproductbyname/searchproductbyname.component';
import { UserheaderComponent } from './userheader/userheader.component';
import { AddproductComponent } from './addproduct/addproduct.component';
import { AdminComponent } from './admin/admin.component';
import { AllproductComponent } from './allproduct/allproduct.component';
import { AuthgaurdService } from './services/authgaurd.service';
import { AuthService } from './services/auth.service';
import { TokenInterceptorService } from './services/token-interceptor.service';


@NgModule({
  declarations: [
MasterComponent,
LoginComponent,
RegisterComponent,
DashboardComponent,
HomeComponent,
SearchproductbynameComponent,
UserheaderComponent,
AddproductComponent,
AdminComponent,
AllproductComponent,

  
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(Mainroutes),
    HttpClientModule
  ],
  providers: [AuthgaurdService,AuthService, { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptorService, multi: true }],
  bootstrap: [MasterComponent]
})
export class AppModule { }
