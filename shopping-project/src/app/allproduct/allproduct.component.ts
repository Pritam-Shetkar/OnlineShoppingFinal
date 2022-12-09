import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { productdata } from '../models/productdata';

@Component({
  selector: 'app-allproduct',
  templateUrl: './allproduct.component.html',
  styleUrls: ['./allproduct.component.css']
})
export class AllproductComponent implements OnInit {
  constructor(private http: HttpClient) { }
  
  ngOnInit(): void {
    this.GetProductData();
  }

  GetProductData() {
    this.http.get(" https://shoppingapp.azurewebsites.net/api/Product/GetAllproduct").subscribe(res => this.GetFromServer(res), res => console.log(res));
  }
  GetFromServer(res: any) {
    console.log(res);
    this.proddatas = res;
  }
  proddata: productdata = new productdata();
  proddatas: Array<productdata> = new Array<productdata>();
}
