import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Customer } from "../module/customer";

//@Injectable({
//  providedIn: 'root'
//})

export class CustomerService {

  Url = 'http://localhost:52317/Api/Customer';
  constructor(private http: HttpClient) { }
  GetCustomer(): Observable<Customer[]> {
    return this.http.get<Customer[]>(this.Url);
  }

}  
