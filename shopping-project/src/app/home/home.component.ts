import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
 selector: 'app-home',
 //selector:'app-root',
  templateUrl: './home.component.html',

})
export class HomeComponent implements OnInit {

    imgUrl:any="././assets/Samsung_M30.jpg";
    shoesUrl:any="././assets/Puma Shoes.jpg";
    redmiTv:any="././assets/Redmi Mi Tv.jpg";
  constructor(private http:HttpClient) { }
  ngOnInit(): void {
   
  }
  
  }

