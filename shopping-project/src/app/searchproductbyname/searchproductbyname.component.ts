import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { productdata } from '../models/productdata';

@Component({
  selector: 'app-searchproductbyname',
  templateUrl: './searchproductbyname.component.html',

})
export class SearchproductbynameComponent implements OnInit {

  SearchModel: productdata = new productdata();
  SearchModels: Array<productdata> = new Array<productdata>();
  srchbk:productdata=new productdata();
 constructor(private http:HttpClient) { }
 ngOnInit(): void {
  // this.GetFlightrData()
 }

 GetSearchData() {
  this.http.get(" https://shoppingapp.azurewebsites.net/api/Product/SearchProductByName?pName="+this.SearchModel.pName).
  subscribe(res => this.GetFromServer(res), res => console.log(res));
}
GetFromServer(res: any) {
  console.log(res);
  this.srchbk = res;
}


AddSearch() {
  var searchdto = {
    PNAME: this.SearchModel.pName
  }
  console.log(searchdto);
  console.log(this.SearchModel);

 this.SearchModel = new productdata();

}

}
