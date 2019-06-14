"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
//@Injectable({
//  providedIn: 'root'
//})
var CustomerService = /** @class */ (function () {
    function CustomerService(http) {
        this.http = http;
        this.Url = 'http://localhost:52317/Api/Customer';
    }
    CustomerService.prototype.GetCustomer = function () {
        return this.http.get(this.Url);
    };
    return CustomerService;
}());
exports.CustomerService = CustomerService;
//# sourceMappingURL=customer.service.js.map