import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-unit-conversion',
  templateUrl: './unit-conversion.component.html',
  styleUrls: ['./unit-conversion.component.css']
})
export class UnitConversionComponent implements OnInit {
  baseURL: any;
  outputTemperature: number;
  httpClient: HttpClient;
  conversionReq: ConverionRequest = {
    temperature: 0,
    fromUnit: "Celcius",
    toUnit: "Celcius"
  };
  updateForm: FormGroup;

  constructor(@Inject('BASE_URL') baseUrl: string, private formBuilder: FormBuilder, http: HttpClient) {
    this.baseURL = baseUrl;
    this.httpClient = http;
  }
  ngOnInit() {
    this.updateForm = this.formBuilder.group({
      inputTemperature: [],
      fromUnits: [],
      toUnits: [],
      outputTemperature: []
    });
  }
  public convert() {
    this.httpClient.post<number>(this.baseURL + 'unitconversion', this.conversionReq).subscribe(result => {
      this.outputTemperature = result;
    }, error => console.error(error));
  }
}

export interface ConverionRequest {
  temperature: number;
  fromUnit: string;
  toUnit: string;

}
