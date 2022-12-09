import { AddproductComponent } from "../addproduct/addproduct.component";
import { AdminComponent } from "../admin/admin.component";
import { AllproductComponent } from "../allproduct/allproduct.component";
import { DashboardComponent } from "../dashboard/dashboard.component";
import { HomeComponent } from "../home/home.component";
import { LoginComponent } from "../login/login.component";
import { RegisterComponent } from "../register/register.component";
import { SearchproductbynameComponent } from "../searchproductbyname/searchproductbyname.component";
import { AuthgaurdService } from "../services/authgaurd.service";
import { UserheaderComponent } from "../userheader/userheader.component";

export const Mainroutes= [
   {path:'login',component:LoginComponent},
   {path:'admin',component:AdminComponent},
   {path:'allproduct',component:AllproductComponent},
   {path:'register',component:RegisterComponent},
   {path:'dashboard',component:DashboardComponent},
   {path:'',component:HomeComponent},
 
   {path:'home',component:HomeComponent},
   {path:'searchproductbyname',canActivate:[AuthgaurdService],component:SearchproductbynameComponent},
   {path:'userheader',component:UserheaderComponent},
   {path:'addproduct',canActivate:[AuthgaurdService],component:AddproductComponent}
];