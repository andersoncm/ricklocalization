import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-erro-servidor',
  templateUrl: './erro-servidor.component.html',
  styleUrls: ['./erro-servidor.component.css']
})
export class ErroServidorComponent implements OnInit {
  public reportedError: boolean;
  public errorPercentage: number = 0;
  public timer;

  constructor() { }

  ngOnInit(): void {
  }

  public checkChanged = (event) => {
    this.reportedError = event.checked;

    this.reportedError ? this.startTimer() : this.stopTimer();
  }

  private startTimer = () => {
    this.timer = setInterval(() => {
      this.errorPercentage += 1;

      if (this.errorPercentage === 100) {
        clearInterval(this.timer);
      }
    }, 30);
  }

  private stopTimer = () => {
    clearInterval(this.timer);
    this.errorPercentage = 0;
  }

}
