import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../service/customer.service';
import { Customer } from "../module/customer";
import { Observable } from "rxjs";

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  private _allCustomer: Observable<Customer[]>;
  public get allCustomer(): Observable<Customer[]> {
    return this._allCustomer;
  }
  public set allCustomer(value: Observable<Customer[]>) {
    this._allCustomer = value;
  }
  constructor(public customerService: CustomerService) { }

  loadDisplay() {
    debugger;
    this._allCustomer = this.customerService.GetCustomer();

  }
  ngOnInit() {
    this.loadDisplay();
  }

}   
