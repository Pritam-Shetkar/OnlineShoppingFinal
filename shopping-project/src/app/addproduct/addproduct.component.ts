import { HttpClient, HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { productdata } from '../models/productdata';


@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',

})
export class AddproductComponent implements OnInit {
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
  Addbooking() {
    var productto = {
      pId: Number(this.proddata.pId),
    pName: this.proddata.pName,
      pColor: this.proddata.pColor,
      pPrize: Number(this.proddata.pPrize),
      pSize: this.proddata.pSize,
      pType: this.proddata.pType,

    }
    console.log(productto);
    console.log(this.proddata);
    this.http.post(" https://shoppingapp.azurewebsites.net/api/Product/AddProduct", productto).subscribe(res => { this.GetProductData(); console.log(res) }, res => console.log(res));
    this.proddata = new productdata();
  }

  EditProduct(cust: productdata) {
    this.proddata = cust;
  }
  DeleteProduct(cust: productdata) {
    console.log(cust);
    let httparms = new HttpParams().set("Id", cust.pId);
    let options = { params: httparms };
    // this.CustomerModels=this.arrayRemove( this.CustomerModels,Customer)
    this.http.delete(" https://shoppingapp.azurewebsites.net/api/Product/ProductDeleteById", options).subscribe(res => { this.GetProductData(); console.log(res) }, res => console.log(res));

  }

  arrayRemove(arr: any, value: any) {
    return arr.filter(function (sample: any) {
      return sample != value;
    });
  }


}