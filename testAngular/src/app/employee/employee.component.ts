import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-employee',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css'
})
export class EmployeeComponent {
  a=10;
  b=20;
  employee={
    id: 1,
    name: "Daniel",
    age: 10,
    salary: 5000,
    dob: "11/25/1983"
  }
  employeeName = "Smith";
  countries = ["USA","US","CHINA","INDIA"]
  showDiv = true;
  showMessage(){
    // alert("button");
    this.showDiv = ! this.showDiv;
  }
}
