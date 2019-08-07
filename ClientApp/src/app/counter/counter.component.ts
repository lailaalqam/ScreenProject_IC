import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent {
  public events: any[];
  public interval = 10000;
  SwappingTime = 1000;
  selectedEventIndex = 0;
  selectedEvent: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.GetEventt(http, baseUrl);
    this.Reload(http, baseUrl);

  }

  GetEventt(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/Event').subscribe(result => {
      this.events = result;
      console.log(this.events);

      this.selectedEvent = this.events[this.selectedEventIndex];
      this.Swap();


    }, error => console.error(error)
    );
  }

  Reload(http: HttpClient, @Inject('BASE_URL') baseUrl: string): void {
    setInterval(() => {
      this.GetEventt( http,baseUrl);
    }, this.interval);

  }

  Swap(): void {

    setInterval(() => {
      this.selectedEventIndex = (this.selectedEventIndex + 1) % this.events.length;
      this.selectedEvent = this.events[this.selectedEventIndex];
    }, this.SwappingTime);


  }



}

