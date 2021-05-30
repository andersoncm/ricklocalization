import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-dialogo-erro',
  templateUrl: './dialogo-erro.component.html',
  styleUrls: ['./dialogo-erro.component.css']
})
export class DialogoErroComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<DialogoErroComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) {

    }

  ngOnInit() {
  }

  public closeDialog = () => {
    this.dialogRef.close();
  }

}
